#if DEBUG
//#define SIMULATE_WIN_10_FONT
#endif

using AndroidSideloader.Properties;
using JR.Utils.GUI.Forms;
using System;
using System.Drawing;
using System.Drawing.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndroidSideloader
{
    public sealed partial class Splash : Form
    {
        private const string BOOT_FONT =
#if !SIMULATE_WIN_10_FONT
            "C:\\Windows\\Boot\\Fonts\\segoen_slboot.ttf";
#else
            // This is obviously specific to my machine. Just comment SIMULATE_WIN_10_FONT if it's uncommented for some reason.
#warning    Make sure the required Windows 10 TTF file exists, change the hard-coded path, or comment out SIMULATE_WIN_10_FONT.
            "D:\\VmShared\\segoen_slboot.ttf";
#endif

        private readonly PrivateFontCollection _privateFonts = new PrivateFontCollection();
        private readonly Timer _spinnerTimer;

        private readonly StartupOptions _startupOptions;
        private readonly HttpClient _httpClient;

        public Splash(StartupOptions startupOptions, HttpClient httpClient)
        {
            InitializeComponent();
            _startupOptions = startupOptions;
            _httpClient = httpClient;

            char[] frames = LoadSpinnerChars();

            if (frames.Length > 0)
            {
                spinner.Font = LoadFont(BOOT_FONT);

                int currentFrame = 0;
                _spinnerTimer = new Timer()
                {
                    Interval = 1000 / 60
                };

                _spinnerTimer.Tick += (sender, e) =>
                {
                    if (currentFrame >= frames.Length)
                    {
                        currentFrame = 0;
                    }

                    spinner.Text = frames[currentFrame].ToString();

                    currentFrame++;
                };

                _spinnerTimer.Start();

                spinner.Height = spinner.Width = 25;
                spinner.Location = new Point(10, Height - spinner.Height - 10);
            }
            else
            {
                spinner.Visible = false;
            }
        }

        public void UpdateBackgroundImage(Image newImage)
        {
            BackgroundImage = newImage;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            Task.Run(async () =>
            {
                try
                {
                    if (_startupOptions.OfflineMode)
                    {
                        UpdateBackgroundImage(Resources.splashimage_offline);
                    }
                    else
                    {
                        UpdateBackgroundImage(Resources.splashimage_deps);
                        await GetDependencies.DownloadDependenciesAsync(_httpClient);

                        UpdateBackgroundImage(Resources.splashimage_rclone);
                        await GetDependencies.DownloadRcloneAsync(_httpClient, _startupOptions.RcloneUpdatesDisabled);

                        UpdateBackgroundImage(Resources.splashimage);
                    }

                    // ~30% of the time MainForm.InitializeComponent will hang while dotnet attempts to load SergeUtils (I'd be fucked to know *why* it takes so long, I'll assume odd compression), so preload it here.
                    _ = Type.GetType(typeof(SergeUtils.DropdownControl).AssemblyQualifiedName);

                    await Task.Delay(1000);
                }
                catch (Exception ex)
                {
                    Invoke((MethodInvoker)(() =>
                    {
                        _ = Logger.Log($"Rookie startup failure: {ex.Message}", LogLevel.FATAL);
                        FlexibleMessageBox.Show($"Failed to start Rookie.\n\n{ex.Message}");
                    }));
                }
                finally
                {
                    Invoke((MethodInvoker)Close);
                }
            });
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            _privateFonts.Dispose();
            _spinnerTimer?.Dispose();

            // The HttpClient is passed from the caller and is shared throughout the app. Do not dispose it.
        }

        private Font LoadFont(string path)
        {
            _privateFonts.AddFontFile(path);
            return new Font(_privateFonts.Families[0], 24, FontStyle.Bold);
        }

        private static char[] LoadSpinnerChars()
        {
            try
            {
                // Win 10 and 11 should have a TTF with the same name, but the spinner characters are in different locations.

                const int W10_START = 0xE052, W10_LAST = 0xE0CB;
                const int W11_START = 0xE100, W11_LAST = 0xE176;

#if SIMULATE_WIN_10_FONT
            return PopulateSpinners(W10_START, W10_LAST);
#endif

                Version osVersion = Environment.OSVersion.Version;

                if (osVersion.Build >= 22000)
                {
                    return PopulateSpinners(W11_START, W11_LAST);
                }
                else if (osVersion.Major is 10)
                {
                    return PopulateSpinners(W10_START, W10_LAST);
                }
            }
            catch (Exception ex)
            {
                _ = Logger.Log($"Failed to load splash spin characters: {ex.Message}", LogLevel.ERROR);
            }

            return Array.Empty<char>();
        }

        private static char[] PopulateSpinners(int start, int last)
        {
            char[] spinChars = new char[last - start];
            for (int i = 0; i < spinChars.Length; ++i)
            {
                spinChars[i] = (char)(start + i);
            }

            return spinChars;
        }
    }
}

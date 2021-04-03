using System;
using System.Windows.Forms;

namespace AndroidSideloader
{
    public partial class QuestForm : Form
    {
        public QuestForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool refr = false;
            bool res = false;
            bool cpu = false;
            bool gpu = false;
            if (RefreshRateComboBox.SelectedIndex != -1)
            {
                ADB.RunAdbCommandToString($"shell setprop debug.oculus.refreshRate {RefreshRateComboBox.SelectedItem.ToString()}");
                ADB.RunAdbCommandToString($"shell settings put global 90hz_global {RefreshRateComboBox.SelectedIndex}");
                ADB.RunAdbCommandToString($"shell settings put global 90hzglobal {RefreshRateComboBox.SelectedIndex}");
                refr = true;
            }

            if (TextureResTextBox.Text.Length>0)
            {
                Int32.TryParse(TextureResTextBox.Text, out int result);
                ADB.RunAdbCommandToString($"shell settings put global texture_size_Global {TextureResTextBox.Text}");
                ADB.RunAdbCommandToString($"shell settings put global texture_size_Global {TextureResTextBox.Text}");
                ADB.RunAdbCommandToString($"shell setprop debug.oculus.textureWidth {TextureResTextBox.Text}");
                ADB.RunAdbCommandToString($"shell setprop debug.oculus.textureHeight {TextureResTextBox.Text}");
                res = true;
            }
            if (CPUBox.SelectedIndex>0)
            {
                ADB.RunAdbCommandToString($"shell setprop debug.oculus.cpuLevel {CPUBox.SelectedItem.ToString()}");
                cpu = true;
            }

            if (GPUBox.SelectedIndex>0)
            {
                ADB.RunAdbCommandToString($"shell setprop debug.oculus.gpuLevel {GPUBox.SelectedItem.ToString()}");
                gpu = true;
            }
            if (gpu || cpu || refr || res)
                MessageBox.Show($"Settings applied! Remember these settings will be reset to default if you reboot your device.");

        }

        private void TextureResTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RefreshRateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GPUBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

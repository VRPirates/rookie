using System;
using System.IO;
using System.Diagnostics;
using AndroidSideloader;

namespace Spoofer
{
    class spoofer
    {
        public static string alias = string.Empty;
        public static string password = string.Empty;

        public static void Init()
        {
            if (File.Exists("keystore.key") == false || File.Exists("details.txt") == false)
            {
                Console.WriteLine("There is no key to sign the apk, making one now...");
                var rand = new Random();
                alias = Utilities.randomString(8);
                password = Utilities.randomString(16);
                string subject = $"CN = {Utilities.randomString(rand.Next(2, 6))}, OU = {Utilities.randomString(rand.Next(2, 6))}, O = {Utilities.randomString(rand.Next(2, 6))}, L = {Utilities.randomString(rand.Next(2, 6))}, ST = {Utilities.randomString(rand.Next(2, 6))}, C = {Utilities.randomString(rand.Next(2, 6))}";

                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.RedirectStandardInput = true;
                cmd.StartInfo.RedirectStandardOutput = true;
                cmd.StartInfo.RedirectStandardError = true;
                cmd.StartInfo.WorkingDirectory = Environment.CurrentDirectory;
                cmd.StartInfo.CreateNoWindow = true;
                cmd.StartInfo.UseShellExecute = false;
                cmd.Start();
                cmd.StandardInput.WriteLine($"keytool -genkeypair -alias {alias} -keyalg RSA -keysize 2048 -keystore keystore.key -keypass {password} -storepass {password} -dname \"{subject}\"");
                cmd.StandardInput.Flush();
                cmd.StandardInput.Close();
                cmd.WaitForExit();
                string keyerror = cmd.StandardError.ReadToEnd();
                string keyoutput = cmd.StandardOutput.ReadToEnd();
                File.WriteAllText("debug.txt", $"Output: {keyoutput} Error: {keyerror}");
                File.WriteAllText("details.txt", $"{alias};{password}");
                Console.WriteLine("Key generated");
            }
            else
            {
                var temp = File.ReadAllText("details.txt").Split(';');
                alias = temp[0];
                password = temp[1];
            }
        }

        public static string folderPath = string.Empty;

        public static string decompiledPath = string.Empty;
        public static string newPackageName = string.Empty;
        public static string originalPackageName = string.Empty;

        public static string spoofedApkPath = string.Empty;

        public static string SpoofApk(string apkPath, string newPackageName, string obbPath = "")
        {
            //Rename
            string output = "";
            string oldGameName = Path.GetFileName(apkPath);
            folderPath = apkPath.Replace(Path.GetFileName(apkPath), "");
            File.Move(apkPath, $"{folderPath}spoofme.apk");
            apkPath = $"{folderPath}spoofme.apk";
            decompiledPath = apkPath.Replace(".apk","");
            //newPackageName = $"com.{Utilities.randomString(rand.Next(3, 8))}.{Utilities.randomString(rand.Next(3, 8))}";
            originalPackageName = PackageName(apkPath);
            Logger.Log($"Your app will be spoofed as {newPackageName}");
            Logger.Log($"Folderpath: {folderPath} decompiledPaht: {decompiledPath} ");
            if (obbPath.Length > 1)
            {
                RenameObb(obbPath,newPackageName,originalPackageName);
            }

            Console.WriteLine("Extracting apk...");
            output += DecompileApk(apkPath);

            Console.WriteLine("Spoofing apk...");
            //Rename APK Packagename
            string foo = File.ReadAllText($"{decompiledPath}\\AndroidManifest.xml").Replace(originalPackageName, newPackageName);
            File.WriteAllText($"{decompiledPath}\\AndroidManifest.xml", foo);
            foreach (string file in Directory.EnumerateFiles(decompiledPath, "*.*", SearchOption.AllDirectories))
            {
                if (Path.GetFileName(file) == "BuildConfig.smali")
                {
                    foo = File.ReadAllText(file).Replace(originalPackageName, newPackageName);
                    File.WriteAllText(file, foo);
                }
            }
            //BMBF
            //if (File.Exists("bmbf.txt"))
            //{
            //    string bspckgname = File.ReadAllText("bmbf.txt");
            //    foreach (string file in Directory.EnumerateFiles(decompiledPath, "*.js", SearchOption.AllDirectories))
            //    {
            //        foo = File.ReadAllText(file).Replace("com.beatgames.beatsaber", bspckgname);
            //        File.WriteAllText(file, foo);
            //    }
            //}
            Console.WriteLine("APK Spoofed");


            Console.WriteLine("Rebuilding the APK...");
            spoofedApkPath = $"{Path.GetFileName(apkPath).Replace(".apk", "")}_Spoofed as {newPackageName}.apk";

            output += Utilities.startProcess("cmd.exe", folderPath, $"apktool b \"{Path.GetFileName(apkPath).Replace(".apk", "")}\" -o \"{spoofedApkPath}\"");
            Logger.Log($"apktool b \"{Path.GetFileName(apkPath).Replace(".apk", "")}\" -o \"{spoofedApkPath}\": {output}");
            Console.WriteLine("APK Rebuilt");

            //Sign the new apk
            Console.WriteLine("Signing the APK...");
            if (File.Exists(folderPath + "keystore.key") == false)
                File.Copy("keystore.key", $"{folderPath}keystore.key");
            output += SignApk(apkPath,newPackageName);

            File.Move($"{folderPath}\\{spoofedApkPath}", $"{folderPath}\\{oldGameName}_ Spoofed as {newPackageName}.apk");
            File.Move(apkPath, $"{apkPath.Replace(Path.GetFileName(apkPath), "")}\\{oldGameName}.apk");

            Console.WriteLine("APK Signed");

            //Delete the copy of the key and the decompiled apk folder
            Console.WriteLine("Deleting residual files...");
            if (string.Equals(folderPath, Environment.CurrentDirectory + "\\") == false)
                File.Delete($"{folderPath}keystore.key");
            Directory.Delete(decompiledPath, true);
            Console.WriteLine("Residual files deleted");

            return output;
        }

        public static string SignApk(string path, string packageName)
        {
            Process cmdSign = new Process();
            cmdSign.StartInfo.FileName = "cmd.exe";
            cmdSign.StartInfo.RedirectStandardInput = true;
            cmdSign.StartInfo.WorkingDirectory = folderPath;
            cmdSign.StartInfo.CreateNoWindow = true;
            cmdSign.StartInfo.UseShellExecute = false;
            cmdSign.StartInfo.RedirectStandardOutput = true;
            cmdSign.Start();
            cmdSign.StandardInput.WriteLine($"jarsigner -verbose -sigalg SHA1withRSA -digestalg SHA1 -keystore keystore.key \"{spoofedApkPath}\" {alias}");
            cmdSign.StandardInput.WriteLine(password);
            cmdSign.StandardInput.Flush();
            cmdSign.StandardInput.Close();
            cmdSign.WaitForExit();
            var output = cmdSign.StandardOutput.ReadToEnd();
            Logger.Log(output);
            return output;
        }

        public static string DecompileApk(string path)
        {
            string output = Utilities.startProcess("cmd.exe", folderPath, $"apktool d -f \"{path}\"");

            Console.WriteLine(output);
            File.AppendAllText("debug.txt", $"apktool d \"{path}\": {output}");
            //If error
            if (Utilities.processError.Length > 1)
                output += $"ERROR: {Utilities.processError}";
            return output;
        }

        //Renames obb to new obb according to packagename
        public static void RenameObb(string obbPath, string newPackageName, string originalPackageName)
        {
            Directory.Move(obbPath, obbPath.Replace(originalPackageName, newPackageName));
            obbPath = obbPath.Replace(originalPackageName, newPackageName);
            foreach (string file in Directory.GetFiles(obbPath))
            {
                if (Path.GetExtension(file) == ".obb")
                {
                    File.Move(file, file.Replace(originalPackageName, newPackageName));
                }
            }
        }

        public static string PackageName(string path)
        {
            Console.WriteLine($"aapt dump badging \"{path}\"");

            string originalPackageName = Utilities.startProcess("cmd.exe", path.Replace(Path.GetFileName(path), string.Empty), $"aapt dump badging \"{path}\" | findstr -i \"package: name\"");
            File.AppendAllText("debug.txt", $"originalPackageName: {originalPackageName}");
            try
            {
                originalPackageName = originalPackageName.Substring(originalPackageName.IndexOf("package: name='") + 15);
                originalPackageName = originalPackageName.Substring(0, originalPackageName.IndexOf("'"));
            }
            catch
            {
                return "PackageName ERROR";
            }
            Console.WriteLine($"Packagename is {originalPackageName}");
            return originalPackageName;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Microsoft.Win32;

namespace FileFindTool.Utils
{
    public static class NotepadPluPlusHelper
    {
        private static string _registryPath;

        private static string CustomPath
        {
            get
            {
                return Config.NotepadPluPlusPath;
            }
        }

        public static string Path
        {
            get
            {
                string path = null;

                if (IsCustomPath())
                {
                    path = CustomPath;
                }
                else
                {
                    if (string.IsNullOrEmpty(_registryPath))
                    {
                        _registryPath = LoadPathFromRegistry();
                    }

                    path = _registryPath;
                }

                return path;
            }
        }


        public static bool IsInstalled()
        {
            bool isInstalled = false;

            if (IsCustomPath())
            {                
                isInstalled = File.Exists(CustomPath);
            }
            else
            {
                isInstalled = CheckRegistry();
            }

            LoadPathFromRegistry();

            return isInstalled;
        }


        private static bool IsCustomPath()
        {
            return !string.IsNullOrEmpty(CustomPath);
        }

    
        private static string LoadPathFromRegistry()
        {
            const string registryKey = @"HKEY_LOCAL_MACHINE\SOFTWARE\Notepad++";

            string directory = (string)Registry.GetValue(registryKey, null, null);
            if (string.IsNullOrEmpty(directory))
            {
                return null;
            }

            string exePath = System.IO.Path.Combine(directory, "Notepad++.exe");
            return exePath;
        }

        private static bool CheckRegistry()
        {
            const string name = "Notepad++";
            string displayName;

            // x86
            string registryKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            RegistryKey key = Registry.LocalMachine.OpenSubKey(registryKey);
            if (key != null)
            {
                foreach (RegistryKey subkey in key.GetSubKeyNames().Select(keyName => key.OpenSubKey(keyName)))
                {
                    displayName = subkey.GetValue("DisplayName") as string;
                    if (displayName != null && displayName.Contains(name))
                    {
                        return true;
                    }
                }
                key.Close();
            }

            // x64
            registryKey = @"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall";
            key = Registry.LocalMachine.OpenSubKey(registryKey);
            if (key != null)
            {
                foreach (RegistryKey subkey in key.GetSubKeyNames().Select(keyName => key.OpenSubKey(keyName)))
                {
                    displayName = subkey.GetValue("DisplayName") as string;
                    if (displayName != null && displayName.Contains(name))
                    {
                        return true;
                    }
                }
                key.Close();
            }
            return false;
        }
    }
}

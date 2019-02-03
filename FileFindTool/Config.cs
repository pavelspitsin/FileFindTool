using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;


namespace FileFindTool
{
    internal static class Config
    {
        public static string DefaultFileType { get; }
        public static string FileTypes { get; }
        public static string SettingsFilePath { get; }
        public static string NotepadPluPlusPath { get; }
        public static string Encodings { get; }

        static Config()
        {
            DefaultFileType = ConfigurationManager.AppSettings["DefaultFileType"];
            FileTypes = ConfigurationManager.AppSettings["FileTypes"];
            SettingsFilePath = ConfigurationManager.AppSettings["SettingsFilePath"];
            NotepadPluPlusPath = ConfigurationManager.AppSettings["NotepadPluPlusPath"];
            Encodings = ConfigurationManager.AppSettings["Encodings"];
        }
    }
}

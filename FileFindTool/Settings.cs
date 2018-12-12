using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using FileFindTool.Models;

namespace FileFindTool
{
    public static class Settings
    {

        private const string LAST_DIRECTORIES_SETTING = "LastDirectoriesSetting";
        private static readonly string _filePath = ".\\user.json";
        
        public static LastDirectories LastDirectories { get; }

        static Settings()
        {
            LastDirectories = new LastDirectories(5);

            if (!string.IsNullOrEmpty(Config.SettingsFilePath))
            {
                _filePath = Config.SettingsFilePath;
            }
        }

        public static void Load()
        {
            try
            {
                string jsonText = File.ReadAllText(_filePath);
                JObject jObject = JObject.Parse(jsonText);
                string[] lastDirectories = jObject[LAST_DIRECTORIES_SETTING].Select(_ => (string)_).ToArray();           
                LastDirectories.AddRange(lastDirectories);
            }
            catch(System.IO.FileNotFoundException)
            {
                // File with settings not found.
                // Will be used default settings
            }
            catch
            {
                throw;
            }
        }

        public static void Save()
        {
            JObject jObject = new JObject();
            jObject[LAST_DIRECTORIES_SETTING] = new JArray(LastDirectories.ToArray());

            try
            {
                File.WriteAllText(_filePath, jObject.ToString(), Encoding.UTF8);
            }
            catch(Exception)
            {
                throw;
            }
        }

    }
}

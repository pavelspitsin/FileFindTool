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

        static Config()
        {
            DefaultFileType = ConfigurationManager.AppSettings["DefaultFileType"];
            FileTypes = ConfigurationManager.AppSettings["FileTypes"];
        }
    }
}

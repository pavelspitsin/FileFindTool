using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FileFindTool.Utils
{
    internal class FileCheckerSingleLine : IFileChecker
    {
        public string SearchText { get; set; }
        public Encoding Encoding { get; set; }

        public FileCheckerSingleLine(string searchText, string encodingName)
        {
            SearchText = searchText;
            Encoding = Encoding.GetEncoding(encodingName);
        }

        public bool Contains(string filePath)
        {
            bool result = false;

            foreach (string line in File.ReadLines(filePath, Encoding))
            {
                if (line.IndexOf(SearchText, StringComparison.OrdinalIgnoreCase) != -1)
                {                  
                    result = true;
                    break;
                }
            }
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FileFindTool.Utils
{
    internal class FileChecker
    {
        public static bool Contains(string filePath, string text, string encodingName)
        {
            bool result = false;

            foreach (string line in File.ReadLines(filePath, Encoding.GetEncoding(encodingName)))
            {
                if (line.IndexOf(text, StringComparison.OrdinalIgnoreCase) != -1)
                {                  
                    result = true;
                    break;
                }
            }
            return result;
        }
    }
}

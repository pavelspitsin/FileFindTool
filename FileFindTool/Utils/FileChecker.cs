using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FileFindTool.Utils
{
    internal class FileChecker
    {
        public static bool Contains(string filePath, string text)
        {
            bool result = false;

            foreach (string line in File.ReadLines(filePath))
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

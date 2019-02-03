using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FileFindTool.Utils
{
    internal class FileCheckerMultiLine : IFileChecker
    {
        private int _maxTextLength;

        public string SearchText { get; set; }
        public Encoding Encoding { get; set; }

        public FileCheckerMultiLine(string searchText, string encodingName, int maxTextLength)
        {
            SearchText = searchText;
            Encoding = Encoding.GetEncoding(encodingName);

            if (maxTextLength < 0 || maxTextLength < searchText.Length)
                throw new ArgumentException("The value bufferSize must be greater than 0 and searchText length.");

            _maxTextLength = maxTextLength;
        }

        public bool Contains(string filePath)
        {
            bool contains = false;

            char[] part1 = new char[_maxTextLength];
            char[] part2 = new char[_maxTextLength];
            char[] buffer = new char[_maxTextLength];

            StringBuilder sb = new StringBuilder(_maxTextLength * 2);

            using (StreamReader reader = new StreamReader(filePath, Encoding))
            {
                while (reader.Peek() >= 0)
                {
                    part2.CopyTo(part1, 0);
                    reader.Read(buffer, 0, buffer.Length);
                    buffer.CopyTo(part2, 0);

                    sb.Clear();

                    if (part1[0] == '\0')
                    {
                        sb.Insert(0, buffer);
                    }
                    else
                    {
                        sb.Insert(0, part1);
                        sb.Insert(part1.Length, part2);
                    }

                    string str = sb.ToString();

                    if (str.ToString().IndexOf(SearchText, StringComparison.OrdinalIgnoreCase) != -1)
                    {
                        contains = true;
                        break;
                    }
                }
            }

            return contains;
        }
    }
}

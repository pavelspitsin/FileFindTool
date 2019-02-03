using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FileFindTool.Utils
{
    internal interface IFileChecker
    {
        bool Contains(string filePath);
    }
}

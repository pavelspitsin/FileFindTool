using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FileFindTool.Utils
{
    public static class RunDLL32Helper
    {
        public static void ShowOpenWithDialog(string path)
        {
            var args = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "shell32.dll");
            args += ",OpenAs_RunDLL " + path;
            System.Diagnostics.Process.Start("rundll32.exe", args);
        }
    }
}

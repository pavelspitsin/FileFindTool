using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FileFindTool.Utils
{
    internal class FilesEnumerator : IDisposable
    {
        private IEnumerator<string> _enumerator;

        public FilesEnumerator(string path, string searchPattern, SearchOption searchOption)
        {   
            _enumerator = Directory.EnumerateFiles(path, searchPattern, searchOption).GetEnumerator();
        }

        public string GetNext()
        {
            if (_enumerator != null && 
                _enumerator.MoveNext())
            {
                return _enumerator.Current;
            }
            else
            {
                _enumerator.Dispose();
                _enumerator = null;
            }

            return null;
        }

        public void Dispose()
        {
            if (_enumerator != null)
            {
                _enumerator.Dispose();
                _enumerator = null;
            }
        }
    }
}

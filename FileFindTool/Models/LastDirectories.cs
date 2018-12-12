using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FileFindTool.Models
{
    public class LastDirectories
    {
        private readonly Queue<string> _queue;

        public int Capactity { get; }

        public LastDirectories(int capacity)
        {
            _queue = new Queue<string>(capacity);
            Capactity = capacity > 0 ? capacity : 0;
        }


        public string Add(string directory)
        {
            string pushed = null;

            if (_queue.Count > 0)
            {
                if (_queue.ToArray().Contains(directory))
                    return null;
            }

            if (_queue.Count == Capactity)
            {
                pushed = _queue.Dequeue();
            }

            _queue.Enqueue(directory);
            return pushed;
        }


        public void AddRange(string[] directories)
        {
            foreach (string directory in directories)
            {
                Add(directory);
            }
        }


        public string[] ToArray()
        {
            return _queue.ToArray();
        }

        public string[] ToArray(bool reverse)
        {
            if (reverse)
            {
                int count = _queue.Count;

                string[] tmpArr = _queue.ToArray();
                string[] reversed = new string[count];

                for (int i = 0; i < count; ++i)
                {
                    reversed[i] = tmpArr[count - i - 1];
                }

                return reversed;
            }

            return ToArray();
        }


        public void Clear()
        {
            _queue.Clear();
        }
    }
}

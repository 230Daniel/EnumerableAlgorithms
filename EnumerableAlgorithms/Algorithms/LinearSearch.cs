using System;

namespace EnumerableAlgorithms.Algorithms
{
    internal class LinearSearch
    {
        private int[] _items;
        private bool _verbose;

        public LinearSearch(bool verbose, params int[] items)
        {
            _verbose = verbose;
            _items = items;
        }

        public void Run(int target)
        {
            Console.Clear();
            Log($"Looking for {target} in [{string.Join(", ", _items)}] using linear search...", true, true);
            foreach (int item in _items)
            {
                Log($"Checking {item}... ", false, false);
                if (item == target)
                {
                    Log("Match", false, true);
                    Log("Linear search completed: True", true, true);
                    return;
                }
                Log("No match", false, true);
            }
            Log("Linear search completed: False", true, true);
        }

        private void Log(string message, bool alwaysLog, bool newLine)
        {
            if (_verbose || alwaysLog)
            {
                if (newLine) Console.WriteLine(message);
                else Console.Write(message);
            }
        }
    }
}

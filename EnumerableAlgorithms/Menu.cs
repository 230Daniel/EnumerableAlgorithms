using System;

namespace EnumerableAlgorithms
{
    internal class Menu
    {
        private string[] _options;

        public Menu(params string[] options)
        {
            _options = options;
        }

        public int GetChoice()
        {
            Console.Clear();
            Console.WriteLine("Select an option...");

            for (int i = 0; i < _options.Length; i++)
                Console.WriteLine($"{i + 1}: {_options[i]}");

            string input = null;
            while (!int.TryParse(input, out int choice) || choice <= 0 || choice > _options.Length)
            {
                if (_options.Length < 9)
                {
                    input = Console.ReadKey().KeyChar.ToString();
                    ClearCurrentConsoleLine();
                }
                else
                    input = Console.ReadLine();
                
            }

            Console.Clear();
            return int.Parse(input) - 1;
        }

        private static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth)); 
            Console.SetCursorPosition(0, currentLineCursor);
        }

        public static int GetInteger(int min, int max)
        {
            Console.Clear();
            Console.WriteLine($"Enter a number between {min} and {max}...");

            string input = null;
            while(!int.TryParse(input, out int choice) || choice < min || choice > max)
            {
                input = Console.ReadLine();
            }

            return int.Parse(input);
        }
    }
}

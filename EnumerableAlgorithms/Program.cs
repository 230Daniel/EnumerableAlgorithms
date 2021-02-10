using System;
using EnumerableAlgorithms.Algorithms;

namespace EnumerableAlgorithms
{
    internal class Program
    {
        private static void Main()
        {
            while (true)
            {
                Menu mainMenu = new Menu("Linear search", "Binary search", "Bubble sort", "Merge sort", "Insertion sort", "Quick sort");
                switch (mainMenu.GetChoice())
                {
                    case 0:
                        LinearSearch linearSearch = new LinearSearch(true, GenerateRandomArray(16));
                        linearSearch.Run(Menu.GetInteger(0, 50));
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Not implemented");
                        break;
                }

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
        }

        private static int[] GenerateRandomArray(int length)
        {
            Random random = new Random();

            int[] array = new int[length];
            for (int i = 0; i < length; i++)
                array[i] = random.Next(0, 50);

            return array;
        }
    }
}

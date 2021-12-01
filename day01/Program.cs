using System;

namespace day01
{
    class Program
    {
        static void Main(string[] args)
        {
            var entries = Array.ConvertAll(System.IO.File.ReadAllLines(@"C:\Projects\advent-of-code-2021\day01\input.txt"), int.Parse);

            Console.WriteLine("Hello World!");

            SolvePartOne(entries);
        }

        private static void SolvePartOne(int[] readings)
        {
            int increaseCount = 0;

            for (int i = 0; i < readings.Length - 1; i++)
            {
                if (readings[i] < readings[i + 1])
                {
                    increaseCount++;
                }
            }

            Console.WriteLine($"There are {increaseCount} increases.");
        }
    }
}

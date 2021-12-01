using System;

namespace day01
{
    class Program
    {
        static void Main(string[] args)
        {
            var entries = Array.ConvertAll(System.IO.File.ReadAllLines(@"C:\Projects\advent-of-code-2021\day01\input.txt"), int.Parse);

            Console.WriteLine("Hello World!");

            //entries = new int[] { 199, 200, 208, 210, 200, 207, 240, 269, 260, 263 };

            //SolvePartOne(entries);
            SolePartTwo(entries);

        }

        private static void SolePartTwo(int[] readings)
        {
            int increaseCount = 0;

            for (int i = 0; i < readings.Length - 3; i++)
            {
                var first = readings[i] + readings[i + 1] + readings[i + 2];
                var second = readings[i + 1] + readings[i + 2] + readings[i + 3];

                if (first < second)
                {
                    increaseCount++;
                }
            }

            Console.WriteLine($"There are {increaseCount} increases in the sliding window.");
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

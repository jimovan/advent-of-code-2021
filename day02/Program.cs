using System;

namespace day02
{
    class Program
    {
        const string forwardKey = "forward";
        const string upKey = "up";
        const string downKey = "down";

        static void Main(string[] args)
        {
            var readings = System.IO.File.ReadAllLines(@"C:\Projects\advent-of-code-2021\day02\input.txt");

            SolvePartOne(readings);
            SolvePartTwo(readings);
        }

        private static void SolvePartTwo(string [] readings)
        {
            int forwardValue = 0, depthValue = 0, aimValue = 0;

            foreach (var cmd in readings)
            {
                var cmds = cmd.Split(' ');
                int value = int.Parse(cmds[1]);

                switch (cmds[0].ToLower())
                {
                    case forwardKey:
                        forwardValue += value;
                        if (aimValue > 0) depthValue += aimValue * value;
                        break;

                    case upKey:
                        aimValue -= value;
                        break;

                    case downKey:
                        aimValue += value;
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine($"Forward value is: {forwardValue}");
            Console.WriteLine($"Depth value is: {depthValue}");
            Console.WriteLine($"The product is: {forwardValue * depthValue}");
        }

        private static void SolvePartOne(string [] readings)
        {
            int forwardValue = 0, depthValue = 0;

            foreach (var cmd in readings)
            {
                var cmds = cmd.Split(' ');
                int value = int.Parse(cmds[1]);

                switch (cmds[0].ToLower())
                {
                    case forwardKey:
                        forwardValue += value;
                        break;

                    case upKey:
                        depthValue -= value;
                        break;

                    case downKey:
                        depthValue += value;
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine($"Forward value is: {forwardValue}");
            Console.WriteLine($"Depth value is: {depthValue}");
            Console.WriteLine($"The product is: {forwardValue * depthValue}");
        }
    }
}

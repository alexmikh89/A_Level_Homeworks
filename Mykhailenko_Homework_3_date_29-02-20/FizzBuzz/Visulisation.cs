using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace FizzBuzz
{
    public class Visulisation
    {
        public static void PrintInfo()
        {
            Console.Clear();

            Console.WriteLine($"Your range is: \"{Data.BorderNumLower}...{Data.BorderNumHigher}\"");

            Console.WriteLine($"The multipliers are: \"{Data.PrimeMultiplier1}\" and \"{Data.PrimeMultiplier2}\"");

            Console.WriteLine();

            Console.WriteLine("Your result:");

            LoadingSimulation();
        }

        static void LoadingSimulation()
        {
            string output = "[                    ]";

            Console.Write(output);

            for (int i = 1; i < output.Length - 1; i++)
            {
                Console.SetCursorPosition(i, Console.CursorTop);

                Console.Write('#');

                Thread.Sleep(10);
            }


            LineOperations.LineClear();

            Console.Write("Ready!");

            Thread.Sleep(700);

            LineOperations.LineClear();
        }
    }
}

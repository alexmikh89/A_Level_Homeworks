using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class Engine
    {
        public static void StartDefaultRun()
        {
            Visulisation.PrintInfo();

            Logics.Conversion();

            Console.WriteLine();

            NewRunApproving();
        }


        static void StartCustomRun()
        {

            Data.DataInput();

            Visulisation.PrintInfo();

            Logics.Conversion();

            Console.WriteLine();

            NewRunApproving();
        }

        static void NewRunApproving()
        {
            Console.Write("Do you want to do it again with other range and multiplies? (y/n):");

            ConsoleKey pressedKey = Console.ReadKey().Key;

            if (pressedKey == ConsoleKey.Y) { Console.Clear(); Engine.StartCustomRun(); } // user's custom range and multiplies

            else if (pressedKey == ConsoleKey.N) { Console.Clear(); } //clearing buffer, going to Main program and preparing to quit

            else { LineOperations.LineClear(); NewRunApproving(); } //to stop dummies
        }

    }
}

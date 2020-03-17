using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkierLib
{
    public class Engine
    {
        public static void Run()
        {
            Data.DataInput();

            Visulisation.PrintInfo();

            Console.WriteLine();

            SaveApproving();

            SavesPrintApproving();

            NewRunApproving();
        }

        static void NewRunApproving()
        {
            Console.Write("Do you want to calculate one more training plan? (y/n):");

            ConsoleKey pressedKey = Console.ReadKey().Key;

            if (pressedKey == ConsoleKey.Y) { Console.Clear(); Engine.Run(); } // do the calculations again

            else if (pressedKey == ConsoleKey.N) { Console.Clear(); } //clearing buffer, going to Main program and preparing to quit

            else { LineOperations.LineClear(); NewRunApproving(); } //to stop dummies
        }

        static void SaveApproving()
        {
            Console.Write("Do you want to save results? (y/n):");

            ConsoleKey pressedKey = Console.ReadKey().Key;

            if (pressedKey == ConsoleKey.Y) { ResultSaving.Save(); } // do the calculations again

            else if (pressedKey == ConsoleKey.N) { } //mpving to next step in engine.run 

            else { LineOperations.LineClear(); NewRunApproving(); }

            LineOperations.LineClear();
        }
        static void SavesPrintApproving()
        {
            Console.Write($"Do you want to print saved results ({ResultSaving.SaveList.Count} availble)? (y/n):");

            ConsoleKey pressedKey = Console.ReadKey().Key;

            if (pressedKey == ConsoleKey.Y) { ResultSaving.PrintResults(); } 

            else if (pressedKey == ConsoleKey.N) { } 

            else { LineOperations.LineClear(); NewRunApproving(); }

            LineOperations.LineClear();
        }

        

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Homework1Library
{
    public class SolutionOptions //class to store brenching methods in solutinon
    {
        //if user wants to solve new equation - its need to be approved
        public static void NewEquationInputApproving()
        {
            Console.Write("Do you want to solve another aquetion? (y/n):");

            ConsoleKey pressedKey = Console.ReadKey().Key;

            if (pressedKey == ConsoleKey.Y)
            { DataInputForConsole.DataReset(); Engine.Start(); } // resetting koeffcients and execution calculations again

            else if (pressedKey == ConsoleKey.N) { Console.Clear(); Console.WriteLine(); } //clearing buffer, going to Main program and preparing to quit

            else { LineOperations.LineClear(); NewEquationInputApproving(); } //to stop dummies
        }

        //if user wants to get linear multilies - its need to be approved
        public static void LinearMultiplesDicompositionApproving()
        {
            Console.Write("Do you want to decompose aquetion to linear multiples? (y/n):");

            ConsoleKey pressedKey = Console.ReadKey().Key;

            if (pressedKey == ConsoleKey.Y) { LineOperations.LineClear(); LinearMultiplesDecomposition.GetResult(); } // if user wants - decomposing
            else if (pressedKey == ConsoleKey.N) { LineOperations.LineClear(); } //if not - deleting question from console
            else
            {
                LineOperations.LineClear();
                LinearMultiplesDicompositionApproving();
            }
        }

        //if there were some mistakes discovered in input - user can correct them
        internal static void CorrectInputApproving()
        {
            Console.Write("Is everything correct? Solve the equastion? (y/n):  ");

            ConsoleKey pressedKey = Console.ReadKey().Key;

            if (pressedKey == ConsoleKey.Y) { } // going to the next step in engine class

            else if (pressedKey == ConsoleKey.N)
            { DataInputForConsole.DataReset(); DataInputForConsole.DataInput(); } //flushing inputted data, inputting again

            else { LineOperations.LineClear(); CorrectInputApproving(); }
        }

        //user shouyld approve results saving
        public static void ResultSavingApproving()
        {
            Console.Write("Do you want to save results? (y/n):");

            ConsoleKey pressedKey = Console.ReadKey().Key;

            if (pressedKey == ConsoleKey.Y) { LineOperations.LineClear(); ResultSaving.Save(); }
            else if (pressedKey == ConsoleKey.N) { LineOperations.LineClear(); }
            else
            {
                LineOperations.LineClear();
                ResultSavingApproving();
            }
        }

    }
}

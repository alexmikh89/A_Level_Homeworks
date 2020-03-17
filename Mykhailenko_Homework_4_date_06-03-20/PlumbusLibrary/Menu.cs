using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlumbusLibrary
{
    public class Menu
    {
        public static void MainMenu()
        {
            Console.Clear();

            Console.WriteLine("You are in the main menu. Choose, what do you want to do:");
            Console.WriteLine();

            Console.WriteLine("   _I_nput new plumbus?");
            Console.WriteLine("   _P_rint info for all plumbuses in box?");
            Console.WriteLine("   _R_move an existing plumbus from box?");
            Console.WriteLine("   _S_pecific plumbus info print?");
            Console.WriteLine("   _Q_uit?");

            Console.WriteLine();

            Console.Write("Your answer (I/P/R/S/Q):");

            ConsoleKey pressedKey = Console.ReadKey().Key;

            if (pressedKey == ConsoleKey.I) { Console.Clear(); Plumbus.InputNewPlumbus(); }

            else if (pressedKey == ConsoleKey.P) { Console.Clear(); PlumbusBox.PrintAll(); }

            else if (pressedKey == ConsoleKey.R) { Console.Clear(); PlumbusBox.RemovePlumbus(); }

            else if (pressedKey == ConsoleKey.S) { Console.Clear(); PlumbusBox.SpecificPlumbusPrint(); }

            else if (pressedKey == ConsoleKey.Q) { Console.Clear(); return; }

            else { Console.Clear(); MainMenu(); }

            MainMenu();
        }
    }
}

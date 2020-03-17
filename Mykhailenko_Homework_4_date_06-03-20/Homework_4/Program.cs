using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlumbusLibrary;
using System.Threading;

namespace Homework_4
{
    class Program
    {
        internal static void Main(string[] args)
        {
            Console.WriteLine("Storage box for plumbuses.\n");

            Console.WriteLine("Please, note: the code has no incorrect input protection!");
            Console.WriteLine("Be careful with indexes and variable types.");
            Console.WriteLine();

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();

            Console.Clear();


            // Initialising some plumbuses.

            Plumbus firstPlumbus = new Plumbus("Plumbus 6", 3.5m, "04beta2020", true,
                new Plumbus.DingleBop(), new Plumbus.Chumble(), new Plumbus.Grumbo(), new Plumbus.Grodus());

            Plumbus secondPlumbus = new Plumbus("Plumbus 8", 4.8m, "50sept600", false,
                new Plumbus.DingleBop(15, 30), new Plumbus.Chumble(18, 20), new Plumbus.Grumbo(120, 40),
                new Plumbus.Grodus());

            Plumbus thirdPlumbus = new Plumbus("Plumbus X", 6.5m, "7z14hwd8", true,
                new Plumbus.DingleBop(20, 20), new Plumbus.Chumble(18, 25), new Plumbus.Grumbo(120, 10),
                new Plumbus.Grodus());


            // Creating a new box for plumbuses, adding plumbuses.

            PlumbusBox plumbusBox = new PlumbusBox();

            PlumbusBox.Add(firstPlumbus);
            PlumbusBox.Add(secondPlumbus);
            PlumbusBox.Add(thirdPlumbus);


            // Indexation test.

            Console.WriteLine("Indexation test, expecting Plumbus 8 in output.");
            Console.WriteLine();

            plumbusBox[1].PrintInfo();
            Console.WriteLine();

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

            Console.Clear();


            // Deleting from the class by an index.

            PlumbusBox.Add(firstPlumbus);

            PlumbusBox.RemoveAt(3);


            // Enumeration test with "foreach".

            Console.WriteLine("Enumeration test, expecting Plumbus 6, 8, 10 infoprint in output.");
            Console.WriteLine("Press any key to continue.");
            Console.WriteLine();

            foreach (Plumbus item in plumbusBox)
            {
                item.PrintInfo();
                Console.WriteLine();
            }

            Console.WriteLine("Press any key to continue.");

            //Getting the cursor in top of the page.
            Console.SetCursorPosition(0, 0);

            Console.ReadKey();

            Console.Clear();


            // The Main Menu entery.

            Menu.MainMenu();


            // Quit.

            Console.WriteLine("Good bye...");

            Thread.Sleep(1500);
        }
    }
}

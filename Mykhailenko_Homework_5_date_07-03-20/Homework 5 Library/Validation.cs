using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5_Library
{
    public class Validation
    {
        public static int InputCheck()
        {
            int cursorX = Console.CursorLeft;
            int cursorY = Console.CursorTop;

            string input = Console.ReadLine();

            if (int.TryParse(input, out int res) && int.Parse(input) > 0)
            {
                return res;
            }

            else
            {
                Console.SetCursorPosition(cursorX, cursorY);

                Console.Write("_<-Incorrect! Input a positive number. Press enter and try again.");

                Console.ReadKey();

                LineOperations.LineClear();

                return InputCheck();
            }
        }

        public static ConsoleKeyInfo YesNoInputCheck(string label)
        {
            Console.Write(label);
            ConsoleKeyInfo readKey = Console.ReadKey();

            LineOperations.LineClear();

            if (readKey.Key == ConsoleKey.Y || readKey.Key == ConsoleKey.N) { return readKey; }
            else
            {
                LineOperations.LineClear();
                YesNoInputCheck(label);
                return readKey; // Not reachable code. Kostil'?
            }
        }


    }
}

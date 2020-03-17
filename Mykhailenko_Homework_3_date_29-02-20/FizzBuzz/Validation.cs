using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class Validation
    {
        public static int IsNum()
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

                Console.Write("_<-Incorrect! Input a number more than \"0\" . Press enter and try again.");

                Console.ReadKey();

                LineOperations.LineClear();

                return IsNum(); // kostil'?
            }
        }

        public static int NumIsPrimeMultilier()
        {
            int cursorX = Console.CursorLeft;
            int cursorY = Console.CursorTop;

            int input = IsNum();

            bool isPrime = true;

            for (int i = 2; i < input; i++)
            {
                if (input % i == 0) { isPrime = false; break; }
            }

            if (isPrime) { return input; }

            else
            {
                Console.SetCursorPosition(cursorX, cursorY);

                Console.Write("_<-Incorrect! Input a prime multiplier (2/3/5/...). Press enter and try again.");

                Console.ReadKey();

                Console.SetCursorPosition(cursorX, cursorY);

                LineOperations.LineClear();


                return NumIsPrimeMultilier();
            }
        }
    }
}

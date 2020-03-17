using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkierLib
{
    public class Validation
    {
        public static double InputCheck()
        {
            int cursorX = Console.CursorLeft;
            int cursorY = Console.CursorTop;

            string input = Console.ReadLine();

            if (double.TryParse(input, out double res)&&double.Parse(input)>=0)
            {
                return res;
            }

            else
            {
                Console.SetCursorPosition(cursorX, cursorY);

                Console.Write("_<-Incorrect! Input a positive number or \"0\". Press enter and try again.");

                Console.ReadKey();

                LineOperations.LineClear();

                return InputCheck();
            }
        }
    }
}

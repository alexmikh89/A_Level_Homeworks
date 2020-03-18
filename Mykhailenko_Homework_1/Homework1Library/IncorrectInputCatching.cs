using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1Library
{
    public class IncorrectInputCatching
    {
        public static double InputErrorCatching()
        {
            int cursorPositionX = Console.CursorLeft; // catching cursror position to remove inputed incorrect text, and rewrite it from the beggining
            int cursorPositionY = Console.CursorTop;

            string inputString = Console.ReadLine();

            if (double.TryParse(inputString, out double res)) { return res; } 

            else
            {
                LineOperations.LineClear(cursorPositionX, cursorPositionY);

                Console.Write("_<-Incorrect! Input a number. Press any key and try again.");

                Console.SetCursorPosition(cursorPositionX, cursorPositionY);
                Console.ReadKey();

                LineOperations.LineClear(cursorPositionX, cursorPositionY);

                return InputErrorCatching(); 
            }
            //double.TryParse(inputString, out double res) ? correctInput(inputString) : incorrectInput();  //need an explaination why it isnt works. make a mark for lesson, pls
        } //catching errors, parsing

    }
}

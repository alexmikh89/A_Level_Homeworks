using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlumbusLibrary
{
    // class with method for editing strings in console buffer 
    public class LineOperations
    {
        public static void LineClear()
        {
            int cursorPositionY = Console.CursorTop;

            Console.MoveBufferArea(0, cursorPositionY+1, Console.BufferWidth, 1, 0, cursorPositionY, ' ', Console.ForegroundColor, Console.BackgroundColor);
            Console.SetCursorPosition(0, cursorPositionY);
        }

        public static void LineClear(int cursorPositionX, int cursorPositionY)
        {
            Console.MoveBufferArea(cursorPositionX, cursorPositionY+1, Console.BufferWidth, 1, cursorPositionX, cursorPositionY, ' ', Console.ForegroundColor, Console.BackgroundColor);
            Console.SetCursorPosition(cursorPositionX, cursorPositionY);
        }
    }
}
using System;

namespace Figures_Library
{
    // class with methods for editing strings in console buffer 
    public class LineOperations
    {
        public static void LineClear()
        {
            int cursorPositionY = Console.CursorTop;

            Console.MoveBufferArea(0, cursorPositionY + 1, Console.BufferWidth, 1, 0, cursorPositionY, ' ', Console.ForegroundColor, Console.BackgroundColor);
            Console.SetCursorPosition(0, cursorPositionY);
        }

        public static void LineClear(int stringsToRemove)
        {
            while (stringsToRemove > 0)
            {
                LineClear();
                Console.CursorTop -= 1;
                Console.CursorLeft = 0;
                LineClear();
                stringsToRemove--;
            }
        }
    }
}
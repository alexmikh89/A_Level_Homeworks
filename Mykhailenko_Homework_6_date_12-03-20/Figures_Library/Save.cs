using System;
using System.Collections.Generic;

namespace Figures_Library
{
    class Save
    {
        public static List<IFigure> SavingList { get; private set; } = new List<IFigure>();


        public static void ListSaving(IFigure figure)
        {
            Console.Write("Save your figure?(Y/N): ");

            ConsoleKeyInfo pressedKey = Console.ReadKey();
            switch (pressedKey.Key)
            {
                case (ConsoleKey.Y):
                    SavingList.Add(figure);
                    break;
                case (ConsoleKey.N):
                    return;
                default:
                    Console.Write("Please make a choice (Y/N). Press any key to retry.");
                    Console.ReadKey();

                    LineOperations.LineClear();

                    ListSaving(figure);
                    break;
            }
        }
    }
}

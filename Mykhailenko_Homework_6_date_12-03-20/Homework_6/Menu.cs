using Figures_Library;
using System;

namespace Homework_6
{
    public static class Menu
    {
        public static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("You are in the main menu.\nChoose your menu item:\n");

            Console.WriteLine(" - Create a new figure.");
            Console.WriteLine(" - Show all saved figures (Figure type and name only).");
            Console.WriteLine(" - Quit.\n");

            Console.Write("Please, input your option (C/S/Q): ");

            ConsoleKeyInfo pressedKey = Console.ReadKey();
            switch (pressedKey.Key)
            {
                case (ConsoleKey.C):
                    NewFigureInput();
                    break;

                case (ConsoleKey.S):
                    Info.PrintOverallInfo();
                    break;

                case (ConsoleKey.Q):
                    Console.Clear();
                    return;

                default:
                    LineOperations.LineClear();
                    Console.WriteLine("Please, press only a proposed key. Press any key to retry.");
                    Console.ReadKey();
                    MainMenu();
                    break;
            }

            MainMenu();
        }


        public static void NewFigureInput()
        {
            Console.Clear();

            Console.WriteLine("You are in a figure creating menu.");
            Console.WriteLine("Please, choose a figure you want to create: \n");

            Console.WriteLine(" - Circle.");
            Console.WriteLine(" - Square.");
            Console.WriteLine(" - Rectangle.");
            Console.WriteLine(" - Triangle.");
            Console.WriteLine(" - Quit to the main menu.");

            Console.WriteLine();


            Console.Write("Please, input your option (C/S/R/T/Q): ");

            ConsoleKeyInfo pressedKey = Console.ReadKey();

            // Chosing a constructor for a new figure.
            switch (pressedKey.Key)
            {
                case (ConsoleKey.C):
                    Circle.NewCircleInput();
                    break;
                case (ConsoleKey.S):
                    Square.NewSquareInput();
                    break;
                case (ConsoleKey.R):
                    Rectangle.NewRectangleInput();
                    break;
                case (ConsoleKey.T):
                    Triangle.NewTriangleInput();
                    break;
                case (ConsoleKey.Q):
                    MainMenu();
                    break;
                default:
                    LineOperations.LineClear();

                    Console.WriteLine("Please, press only a proposed key. Tap any key to retry.");
                    Console.ReadKey();
                    NewFigureInput();
                    break;
            }
        }
    }
}

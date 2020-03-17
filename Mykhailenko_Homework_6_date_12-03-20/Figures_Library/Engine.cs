using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures_Library
{
    public static class Engine
    {
        private static List<IFigure> SavingList { get; set; } = new List<IFigure>();

        public static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("You are in the main menu.\nChoose your menu item:\n");

            Console.WriteLine(" - Create a new figure.");
            Console.WriteLine(" - Show all saved figures (figure type and name only).");
            Console.WriteLine(" - Quit.\n");

            Console.Write("Please, input your option (C/S/Q): ");


            ConsoleKeyInfo pressedKey = Console.ReadKey();

            switch (pressedKey.Key)
            {
                case (ConsoleKey.C):
                    NewFigureInput();
                    break;

                case (ConsoleKey.S):
                    PrintOverallInfo();
                    break;

                case (ConsoleKey.Q):
                    break;

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

        public static void FigureSaving(IFigure figure)
        {
            Console.Write("\nSave your figure?(Y/N): ");

            ConsoleKeyInfo pressedKey = Console.ReadKey();

            switch (pressedKey.Key)
            {
                case (ConsoleKey.Y):
                    SavingList.Add(figure);
                    break;
                default:
                    break;
            }
        }

        public static void PrintOverallInfo()
        {
            int chosenFigure;

            Console.Clear();
            Console.WriteLine("You are in the savings overview menu.");
            Console.WriteLine("Choose a figure's number to view detailed info or Q to quit to the main menu.\n");

            if (SavingList.Count == 0)
            {
                Console.WriteLine("No saved figures yet.\n");

                Console.Write("Press any key to quit.");
                Console.ReadKey();

                MainMenu();
            }

            int figureCounter = 1;
            for (int i = 0; i < SavingList.Count; i++)
            {
                Console.WriteLine($"Figure #{figureCounter++}: {SavingList[i].GetType().Name}.");

                Console.WriteLine($"Name: {SavingList[i].Name}.\n");
            }

            Console.Write("Choose an option (1/2/3/.../Q): ");

            string input = Console.ReadLine();


            if (input == "Q") { MainMenu(); }

            chosenFigure = InputValidation.SaveMenuChoiceInputValidation(input, SavingList.Count);


            DetailedFigureInfoPrint(chosenFigure);
        }


        public static void DetailedFigureInfoPrint(int number)
        {
            Console.Clear();

            Console.WriteLine("This isTab with a deatailed info about the chosen figure.");

            Console.WriteLine($"Figure #{number}");
            Console.WriteLine(SavingList[number - 1].ToString());
            Console.WriteLine();

            Console.Write("Press any key to return to the main menu.");
            Console.ReadKey();

            MainMenu();
        }
    }
}

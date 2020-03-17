using System;

namespace Figures_Library
{
    public static class Info
    {
        public static void PrintOverallInfo()
        {
            Console.Clear();

            Console.WriteLine("You are in the savings overview menu.");
            Console.WriteLine("Choose a figure's number to view detailed info or Q to quit to the main menu.\n");

            if (Save.SavingList.Count == 0)
            {
                Console.WriteLine("No saved figures yet.\n");

                Console.Write("Press any key to quit.");
                Console.ReadKey();

                return;
            }

            int figureCounter = 1;
            for (int i = 0; i < Save.SavingList.Count; i++)
            {
                Console.WriteLine($"Figure #{figureCounter++}: {Save.SavingList[i].GetType().Name}.");

                Console.WriteLine($"Name: {Save.SavingList[i].Name}.\n");
            }

            Console.Write("Choose an option and press enter (1/2/3/.../Q): ");
            string input = Console.ReadLine();
            if (input == "Q"|| input == "q") { return;}

            // If inputted string is a num - confirming that it is a save list index. 
            int chosenFigure = InputValidation.SaveMenuChoiceInputValidation(input, Save.SavingList.Count);

            DetailedFigureInfoPrint(chosenFigure);
        }

        public static void DetailedFigureInfoPrint(int number)
        {
            Console.Clear();

            Console.WriteLine("This tab represents a deatailed info about the chosen figure.");

            Console.WriteLine($"Figure #{number}");
            Console.WriteLine(Save.SavingList[number - 1].ToString());
            Console.WriteLine();

            Console.Write("Press any key to return to the main menu.");
            Console.ReadKey();
           
            return;
        }
    }
}

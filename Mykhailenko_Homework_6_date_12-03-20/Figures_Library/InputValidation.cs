using System;

namespace Figures_Library
{
    public static class InputValidation
    {
        public static double DoubleValidation(string label)
        {
            Console.Write(label);

            if (double.TryParse(Console.ReadLine(), out double res)) { return res; }

            LineOperations.LineClear();

            Console.Write("Please, input your value in a \"double\" format. Any key to retry.. ");

            Console.ReadKey();

            LineOperations.LineClear(1);

            return DoubleValidation(label);
        }


        public static int SaveMenuChoiceInputValidation(string input, int savingListCount)
        {
            if (int.TryParse(input, out int res) && (res <= savingListCount))
            {
                return res;
            }
            else
            {
                LineOperations.LineClear();

                Console.Write("Please, input a proposed number, or \"Q\". Any key to retry.. ");

                Console.ReadKey();

                Info.PrintOverallInfo();
            }
            return 0;
        }
    }
}

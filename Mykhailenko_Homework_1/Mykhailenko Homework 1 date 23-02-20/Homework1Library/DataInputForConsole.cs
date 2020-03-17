using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1Library
{

    public class DataInputForConsole
    {
        public static string InitialEquation { get; private set; } //

        public static double firstKoeff = 0;
        public static double secondKoeff = 0;
        public static double thirdKoeff = 0;

        public static void DataInput()
        {
            firstKoeff = FirstKoefficientInput(firstKoeff, secondKoeff, thirdKoeff);
            secondKoeff = SecondKoefficientInput(firstKoeff, secondKoeff, thirdKoeff);
            thirdKoeff = ThirdKoefficientInput(firstKoeff, secondKoeff, thirdKoeff);

            TitlePrint(firstKoeff, secondKoeff, thirdKoeff);

            InitialEquation = $"({ DataInputForConsole.firstKoeff })*x^2+({DataInputForConsole.secondKoeff})*x+({DataInputForConsole.thirdKoeff})=0";

            SolutionOptions.CorrectInputApproving();
        } // inputing koeffs by user, foe each - refreshing console's buffer

        internal static void TitlePrint(double firstKoeff, double secondKoeff, double thirdKoeff)
        {
            Console.Clear();

            Console.WriteLine("Input koefficients of your quadratic trianomial to solve it: \n" +
                "(Example: 5*x^2+7*x+5=0)");
            Console.WriteLine();

            Console.WriteLine($"Your equation: ({firstKoeff})*x^2+({secondKoeff})*x+({thirdKoeff})=0");
            Console.WriteLine();
        } // strings, that are rewriting consoles buffer, every time when user refreshes koeffs

        public static double FirstKoefficientInput(double firstKoeff, double secondKoeff, double thirdKoeff)
        {
            TitlePrint(firstKoeff, secondKoeff, thirdKoeff);

            Console.WriteLine($"Input first koefficient (Enter to submit): ");

            return IncorrectInputCatching.InputErrorCatching();
        }

        public static double SecondKoefficientInput(double firstKoeff, double secondKoeff, double thirdKoeff)
        {
            TitlePrint(firstKoeff, secondKoeff, thirdKoeff);

            Console.WriteLine($"Input second koefficient (Enter to submit): ");

            return IncorrectInputCatching.InputErrorCatching();
        }

        public static double ThirdKoefficientInput(double firstKoeff, double secondKoeff, double thirdKoeff)
        {
            TitlePrint(firstKoeff, secondKoeff, thirdKoeff);

            Console.WriteLine($"Input third koefficient:  (Enter to submit)");

            return IncorrectInputCatching.InputErrorCatching();
        }

        internal static void DataReset()
        {
            //for resetting koefficents
            firstKoeff = 0;
            secondKoeff = 0;
            thirdKoeff = 0;
        }  

    }
}

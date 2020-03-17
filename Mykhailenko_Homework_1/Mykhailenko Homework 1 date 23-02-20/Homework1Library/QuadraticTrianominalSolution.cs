using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1Library
{
    public class QuadraticTrianominalSolution
    {
        public static double Discriminant { get; private set; } // fields for use in other classes

        public static string FirstRoot { get; private set; }

        public static string SecondRoot { get; private set; }

        public static List<string> EquationSolutionResult { get; private set; }


        public static void GetResult(double a, double b, double c)
        {
            Console.Clear();

            Console.WriteLine($"Your equation is:\n{DataInputForConsole.InitialEquation}\n"); // additioonal print of equation in buffer

            Console.WriteLine("The roots are:");
            foreach (var item in MainCalculation(a, b, c)) //printing roots in console, or not...
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        private static List<string> MainCalculation(double a, double b, double c)
        {
            //calculating discriminant to define the way of solution

            if (DiscriminantCalculation(a, b, c) < 0)
            {
                LinearMultiplesDecomposition.ResultStringClear(); // flushing previous linear multiply decomposition result to avoid its writing in report

                EquationSolutionResult = NoMaterialRoots();
            }
            else if (DiscriminantCalculation(a, b, c) == 0)
            {
                EquationSolutionResult = OneMaterialRoot(a, b, DiscriminantCalculation(a, b, c));
            }
            else
            {
                EquationSolutionResult = TwoMaterialRoots(a, b, DiscriminantCalculation(a, b, c));
            }
            return EquationSolutionResult;
        }


        private static double DiscriminantCalculation(double a, double b, double c)
        {
            double d = Math.Pow(b, 2) - 4 * a * c;

            Discriminant = d; 

            return d;
        }

        private static List<string> NoMaterialRoots() // result list for D<0
        {
            return new List<string>() { "Discriminant os less than 0: No material roots." };
        }


        private static List<string> OneMaterialRoot(double a, double b, double discriminant) // result list for D==0
        {

            return new List<string>() { $"Equation's single root: x={Convert.ToString(FirstRootCalculation(a, b, discriminant))}" };
        }


        private static List<string> TwoMaterialRoots(double a, double b, double discriminant) // result list for D>0
        {

            return new List<string>() { $"First root: x1={Convert.ToString(FirstRootCalculation(a, b, discriminant))}   ", $"Second root: x2={Convert.ToString(SecondRootCalculation(a, b, discriminant))}" };
        }


        private static double FirstRootCalculation(double a, double b, double discriminant)
        {
            double result = (-1 * b + Math.Sqrt(discriminant)) / (2 * a);

            FirstRoot = Convert.ToString(result);

            return result;
        }

        private static double SecondRootCalculation(double a, double b, double discriminant)
        {
            double result = (-1 * b - Math.Sqrt(discriminant)) / (2 * a);

            SecondRoot = Convert.ToString(result);

            return result;
        }
    }
}

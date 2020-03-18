using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Homework1Library
{
    public class ResultSaving
    {
        private static string filePath = @"c:\solutions_report.txt"; //path for txt report saving
        public static string MathematicalEquation { get; private set; }
        public static void Save()
        {
            using (StreamWriter streamWriter = new StreamWriter(filePath, true))
            {
                streamWriter.WriteLine("|  Log time: {0}", System.DateTime.Now);

                streamWriter.Write("|  Aquetion: ");
                MathematicalEquation = DataInputForConsole.InitialEquation.Replace("(", "").Replace(")", "").Replace("^2", "\u00B2").Replace("--", "+").Replace("-+", "-");

                streamWriter.WriteLine(MathematicalEquation);

                streamWriter.Write("|  Roots: ");
                int rootsCount = 0;
                foreach (var item in QuadraticTrianominalSolution.EquationSolutionResult)
                {
                    if (rootsCount > 1) streamWriter.Write(", ");
                    streamWriter.Write($"{item}");
                    rootsCount++;
                }
                streamWriter.WriteLine();

                streamWriter.Write("|  Linear multiples decomposition for trianominal: ");
                streamWriter.WriteLine(String.IsNullOrEmpty(LinearMultiplesDecomposition.ResultString) ? "No data: no material roots" : LinearMultiplesDecomposition.ResultString);

                streamWriter.WriteLine("-"); //devides the report in logical blocks. ...Kostil'?

                streamWriter.Close();
            }

            Console.WriteLine($"Results were succesfully saved in \"{filePath}\" directory.\n");

        }

        public static void PrintSavingPath()
        {
            Console.WriteLine(filePath);
        }

    }
}

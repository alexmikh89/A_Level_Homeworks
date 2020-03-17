using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1Library
{
    public class LinearMultiplesDecomposition
    {
        public static string ResultString { get; private set; } //result xtring with a decomposition for use in reports
        public static void GetResult()
        {
            Console.WriteLine("Linear multiples decomposition for trianominal: ");
            //brenching for result output for different number of roots

            if (QuadraticTrianominalSolution.Discriminant < 0) NoMaterialRootsDecomposition();

            else if (QuadraticTrianominalSolution.Discriminant == 0) OneRootDecomposition();

            else { TwoRootDecomposition(); }
            Console.WriteLine();
        }

        private static void NoMaterialRootsDecomposition()
        {
            ResultString = "No material roots.";
            
            Console.WriteLine(ResultString);
        }


        private static void OneRootDecomposition()
        {
            ResultString = $"{DataInputForConsole.firstKoeff}(x-{QuadraticTrianominalSolution.FirstRoot})(x-{QuadraticTrianominalSolution.FirstRoot})".Replace("--", "+").Replace("-+", "-");
            
                Console.WriteLine(ResultString);
        }


        private static void TwoRootDecomposition()
        {
            ResultString = $"{DataInputForConsole.firstKoeff}(x-{QuadraticTrianominalSolution.FirstRoot})(x-{QuadraticTrianominalSolution.SecondRoot})".Replace("--","+").Replace("-+","-");

            Console.WriteLine(ResultString);
        }

        public static void ResultStringClear() // method for flushing reult string from outer code
        {
            ResultString = null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz;

namespace FizzBuzz
{
    public static class Logics
    {
        public static void Conversion()
        {

            for (int i = Data.BorderNumLower; i <= Data.BorderNumHigher; i++)
            {
                string result = "";

                if (i % Data.PrimeMultiplier1 == 0) { result += "Fizz"; }

                if (i % Data.PrimeMultiplier2 == 0) { result += "Buzz"; }

                if (i % Data.PrimeMultiplier1 != 0 && i % Data.PrimeMultiplier2 != 0) { result += i; }

                Console.WriteLine(result);
            }
        }
    }
}

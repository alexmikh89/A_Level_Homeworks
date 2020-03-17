using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz;
using System.Threading;

namespace Homework_3_FizzBuzz_date_290220
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "The FizzBuzz program";

            Engine.StartDefaultRun();

            Console.WriteLine("Good bye...");

            Thread.Sleep(1500);
        }
    }
}

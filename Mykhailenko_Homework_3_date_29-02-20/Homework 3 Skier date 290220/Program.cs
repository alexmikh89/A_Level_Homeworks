using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkierLib;
using System.Threading;

namespace Homework_3_Skier_date_290220
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "The skier training calculation.";


            Engine.Run();

            Console.WriteLine("Good bye...");

            Thread.Sleep(1500);


        }
    }
}

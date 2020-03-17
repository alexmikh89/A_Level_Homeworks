using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework_5_Library;
using System.Threading;

namespace Mykhailenko_Homework_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine.MainMenu();

            Console.WriteLine("Good bye!");

            Thread.Sleep(1500);
        }
    }
}

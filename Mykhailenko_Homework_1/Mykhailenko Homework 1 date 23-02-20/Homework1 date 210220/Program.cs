using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework1Library;
using System.IO;
using System.Threading;

namespace Homework1_date_210220
{
    class Program
    {
        static void Main(string[] args)
        {
            //program can save results in c:\solutions_report.txt. Hope, you have local disk "C" =)
            Engine.Start();

            Console.WriteLine("Good bye!");

            Thread.Sleep(1500);
        }
    }
}

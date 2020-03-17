using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SkierLib
{
    public class Visulisation
    {
        public static void PrintInfo()
        {
            Console.Clear();

            Console.WriteLine($"Default training distance is: \"{Data.DefaultDistance}\"");

            Console.WriteLine($"Target training distance is: \"{Data.TargetDistance}\"");

            Console.WriteLine($"Training ratio is: \"{Data.TrainingRatio}%\"");


            if (Data.LastTrainingDay-1 <= 0)

            { Console.WriteLine("There can be a mistake mistake in the training plan..."); }

            else { Console.WriteLine("Training plan will be complete in {0} days", Data.LastTrainingDay); }
        ;
        }
    }
}

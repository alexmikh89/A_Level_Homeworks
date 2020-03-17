using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkierLib
{
    public class Data
    {
        public static double DefaultDistance { get; private set; }
        public static double TargetDistance { get; private set; }
        public static double TrainingRatio { get; private set; }
        public static int LastTrainingDay { get; private set; }

        public static void TrainingDaysCalculation()
        {
            int dayCounter = 1;

            double currentTrainingDistance = DefaultDistance;

            double overallTrainingDistance = 0;

            while (overallTrainingDistance < TargetDistance)
            {
                if (dayCounter % 2 == 0) { currentTrainingDistance *= (1 + TrainingRatio/100); }

                overallTrainingDistance += currentTrainingDistance;

                LastTrainingDay=dayCounter++;
            }
        }

        public static void DataInput()
        {
            Console.WriteLine("Enter first day training distance: ");
            DefaultDistance = Validation.InputCheck();

            Console.WriteLine("Enter target training distance: ");
            TargetDistance = Validation.InputCheck();

            Console.WriteLine("Training ratio, % (0,1,2,...): ");
            TrainingRatio = Validation.InputCheck();

            TrainingDaysCalculation(); // inintialising method to calculate training days
        }
    }
}

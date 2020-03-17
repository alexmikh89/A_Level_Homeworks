using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkierLib
{
    class ResultSaving
    {
        public static List<string> SaveList { get; private set; } = new List<string>();

        public static void Save()
        {
            SaveList.Add($"{Data.DefaultDistance} {Data.TargetDistance} {Data.TrainingRatio} {Data.LastTrainingDay}");
        }

        public static void PrintResults()
        {
            Console.Clear();

            Console.WriteLine("Skier's training calulations:");
            Console.WriteLine();

            foreach (string item in SaveList)
            {
                string[] currentResult = item.Split(' ');

                Console.WriteLine($"Skier's training calulation #{SaveList.Count}");

                Console.WriteLine($"First day training distance: {currentResult[0]}");

                Console.WriteLine($"Target training distance: {currentResult[1]}");

                Console.WriteLine("Training ratio: {0}%", currentResult[2]);

                Console.WriteLine($"Days to complete training: {Data.LastTrainingDay}");

                Console.WriteLine();
            }

        }
    }
}

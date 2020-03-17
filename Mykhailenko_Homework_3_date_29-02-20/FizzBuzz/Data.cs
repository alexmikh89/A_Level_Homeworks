using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class Data
    {
        public static int BorderNumLower { get; private set; } = 1;
        public static int BorderNumHigher { get; private set; } = 100;
        public static int PrimeMultiplier1 { get; private set; } = 3;
        public static int PrimeMultiplier2 { get; private set; } = 5;

        class Get
        {
            public static void BorderNum1Input()
            {
                BorderNumLower = Validation.IsNum();
            }
            public static void BorderNum2Input()
            {
                BorderNumHigher = Validation.IsNum();

                if (BorderNumLower > BorderNumHigher) 
                {
                    int replacement = BorderNumLower;
                    BorderNumLower = BorderNumHigher;
                    BorderNumHigher = replacement;
                }
            }
            public static void PrimeMultiplier1Input()
            {
                PrimeMultiplier1 = Validation.NumIsPrimeMultilier();
            }

            public static void PrimeMultiplier2Input()
            {
                PrimeMultiplier2 = Validation.NumIsPrimeMultilier();
            }
        }

        public static void DataInput()
        {
            Console.WriteLine("Enter the first num to define a range: ");
            Get.BorderNum1Input();

            Console.WriteLine("Enter the second num to define a range: ");
            Get.BorderNum2Input();

            Console.WriteLine("Enter the first prime multiplier: ");
            Get.PrimeMultiplier1Input();

            Console.WriteLine("Enter the second prime multiplier: ");
            Get.PrimeMultiplier2Input();
        }

    }
}

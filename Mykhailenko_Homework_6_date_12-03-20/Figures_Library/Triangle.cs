using System;
using System.Collections.Generic;
using System.Linq;

namespace Figures_Library
{
    public struct Triangle : ITriangle
    {
        public string Name { get; set; }
        public double FirstSideLength { get; set; }
        public double SecondSideLength { get; set; }
        public double ThirdSideLength { get; set; }
        public double Perimeter { get; }
        public double Area { get; }


        public Triangle(string name, double firstSideLength, double secondSideLength, double thirdSideLength)
        {
            Name = name;
            FirstSideLength = firstSideLength;
            SecondSideLength = secondSideLength;
            ThirdSideLength = thirdSideLength;
            Perimeter = firstSideLength + secondSideLength + thirdSideLength;
            Area = GetArea();

            double GetArea()
            {
                double halfPerimeter = (firstSideLength + secondSideLength + thirdSideLength) / 2;

                double result = Math.Sqrt(halfPerimeter *
                    (halfPerimeter - firstSideLength) *
                    (halfPerimeter - secondSideLength) *
                    (halfPerimeter - thirdSideLength));

                return result;
            }
        }

        public static void NewTriangleInput()
        {
            Console.Clear();

            Console.WriteLine("You are creating a new triangle.\n");
            Console.Write("Input your triangle's name: ");

            string name = Console.ReadLine();

            // Input validation.
            double firstSideLength = InputValidation.DoubleValidation("First triangle's side's length, mm: ");

            double secondSideLength = InputValidation.DoubleValidation("Second triangle's side's length, mm: ");

            double thirdSideLength = InputValidation.DoubleValidation("Third triangle's side's length, mm: ");


            // Creating on object to save.

            // Validation for triangle's sides (each must be smaller than a half-perimeter).
            // If validation not passed - new triangle input.
            if (((firstSideLength + secondSideLength + thirdSideLength) / 2) <= new List<double> { firstSideLength, secondSideLength, thirdSideLength }.Max())
            {
                Console.WriteLine("Rectangle's sides are not valid. Each must be smaller than a half-perimeter.");
                Console.Write("Press any key to try again.");

                Console.ReadKey();

                NewTriangleInput();
            }


            // If validation passed - creating a new figure.
            else
            {
                Console.WriteLine();

                Save.ListSaving(new Triangle(name, firstSideLength, secondSideLength, thirdSideLength));
            }
        }


        public override string ToString()
        {
            return $"Name: {Name} \nFirst side's length: {FirstSideLength}, mm \nSecond side's length: {SecondSideLength}, \nThird side's length: {ThirdSideLength},mm \nPerimeter: {Perimeter:F3}, mm \nArea: {Area:F3}, mm sqr";
        }
    }
}

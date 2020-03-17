using System;

namespace Figures_Library
{
    public struct Square : ISquare
    {
        public string Name { get; set; }
        public double SideLength { get; set; }

        public double Perimeter { get; }

        public double Area { get; }


        public Square(string name, double sideLength)
        {
            Name = name;
            SideLength = sideLength;
            Perimeter = sideLength * 4;
            Area = sideLength * sideLength;
        }


        public static void NewSquareInput()
        {
            Console.Clear();

            Console.WriteLine("You are creating a new square.\n");
            Console.Write("Input your square's name: ");

            string name = Console.ReadLine();

            // Input validation.
            double sideLength = InputValidation.DoubleValidation("Square's side's length, mm: ");


            // Creating on object to save.
            Square square = new Square(name,sideLength);

            Console.WriteLine();
            Save.ListSaving(square);
        }


        public override string ToString()
        {
            return $"Name: {Name} \nSide's length: {SideLength}, mm \nPerimeter: {Perimeter:F3}, mm \nArea: {Area:F3}, mm sqr";
        }
    }
}

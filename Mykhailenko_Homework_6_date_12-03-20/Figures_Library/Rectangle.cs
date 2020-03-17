using System;

namespace Figures_Library
{
    public struct Rectangle : IRectangle
    {
        public string Name { get; set; }
        public double FirstSideLength { get; set; }
        public double SecondSideLength { get; set; }
        public double Perimeter { get; }
        public double Area { get; }


        public Rectangle(string name, double firstSideLength, double secondSideLength)
        {
            Name = name;
            FirstSideLength = firstSideLength;
            SecondSideLength = secondSideLength;
            Perimeter = 2 * (firstSideLength + secondSideLength);
            Area = firstSideLength * secondSideLength;
        }


        public static void NewRectangleInput()
        {
            Console.Clear();

            Console.WriteLine("You are creating a new rectangle.\n");
            Console.Write("Input your rectangle's name: ");

            string name = Console.ReadLine();

            // Input validation.
            double firstSideLength = InputValidation.DoubleValidation("First rectangle's side's length, mm: ");

            double secondSideLength = InputValidation.DoubleValidation("Second rectangle's side's length, mm: ");


            // Creating on object to save.
            Rectangle rectangle = new Rectangle(name, firstSideLength, secondSideLength);

            Console.WriteLine();
            Save.ListSaving(rectangle);
        }

        public override string ToString()
        {
            return $"Name: {Name} \nFirst side's length: {FirstSideLength}, mm \nSecond side's length: {SecondSideLength}, mm \nPerimeter: {Perimeter:F3}, mm \nArea: {Area:F3}, mm sqr";
        }
    }
}

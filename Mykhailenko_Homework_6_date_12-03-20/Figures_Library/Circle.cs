using System;

namespace Figures_Library
{
    public struct Circle : ICircle
    {
        public string Name { get; set; }

        public double Radius { get; set; }

        public double Perimeter { get; }

        public double Area { get; }


        public Circle(string name, double radius)
        {
            Name = name;
            Radius = radius;
            Area = Math.Pow(Radius, 2) * Math.PI;
            Perimeter = 2 * Math.PI * radius;
        }

        public static void NewCircleInput()
        {
            Console.Clear();

            Console.WriteLine("You are creating a new circle.\n");
            Console.Write("Input your circle's name: ");

            string name = Console.ReadLine();

            // Input validation.
            double radius = InputValidation.DoubleValidation("Circle radius, mm: ");


            Circle circle = new Circle(name, radius);

            Console.WriteLine();
            Save.ListSaving(circle);
        }

        public override string ToString()
        {
            return $"Name: {Name} \nRadius's length: {Radius}, mm \nPerimeter: {Perimeter:F3}, mm \nArea: {Area:F3}, mm sqr";
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlumbusLibrary
{

    public class PlumbusBox : IEnumerable
    {
        public static List<Plumbus> PlumbusBoxList { get; set; } = new List<Plumbus>();

        // Indexer.
        public Plumbus this[int index]
        {
            get
            {
                return PlumbusBoxList[index];
            }

            set
            {
                PlumbusBoxList[index] = value;
            }
        }


        // Enumerable interface realisation.
        public IEnumerator GetEnumerator()
        {
            return PlumbusBoxList.GetEnumerator();
        }


        // Adding a new plumbus.
        public static void Add(Plumbus plumbus)
        {
            PlumbusBoxList.Add(plumbus);
        }


        // Removing plumbus in box by an index.
        public static void RemoveAt(int position)
        {
            PlumbusBoxList.RemoveAt(position);
        }


        // Remove user chosen plumbus (from a menu).
        public static void RemovePlumbus()
        {
            Console.WriteLine("You are in plumbus removing menu. Choose a plumbus to remove.\n");

            int plumbusMenuPosition = 0;
            foreach (Plumbus item in PlumbusBoxList)
            {
                Console.WriteLine($"{$"Plumbus #{++plumbusMenuPosition,-10}",20}\n  Model:{item.Model}\n  ID:{item.PlumbusID}");

                Console.WriteLine();
            }

            Console.Write("Input a number for plumbus to remove: ");
            int plumbusToDelete = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (plumbusToDelete > PlumbusBoxList.Count || plumbusToDelete == 0)
            {
                Console.WriteLine("Something wrong! Try again with a natural num, less than the plumbuses' count!");
                Console.WriteLine("Press enter to continue...");

                RemovePlumbus();
            }

            else { PlumbusBoxList.RemoveAt(plumbusToDelete - 1); }


            Console.WriteLine($"PLumbus #{plumbusToDelete} was succesfully removed!\n");

            Console.WriteLine("Press any key to continue...");

            Console.ReadKey();

            Console.Clear();

            Menu.MainMenu();
        }


        // Printall plumbuses info in box.
        public static void PrintAll()
        {
            Console.WriteLine("Info about all plumbuses in box:\n");

            int count = 0;

            foreach (Plumbus item in PlumbusBoxList)
            {
                Console.WriteLine($"Plumbus #{++count}");

                item.PrintInfo();

                Console.WriteLine();
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            Console.Clear();

            Menu.MainMenu();
        }

        // Print detailed info for a specific plumbus. 
        public static void SpecificPlumbusPrint()
        {
            Console.WriteLine("Choose a plumbus to view a detailed info about.\n");

            int plumbusMenuPosition = 0;
            foreach (Plumbus item in PlumbusBoxList)
            {
                Console.WriteLine($"{$"Plumbus #{++plumbusMenuPosition,10}",20}\n  Model:{item.Model}\n  ID:{item.PlumbusID}");

                Console.WriteLine();
            }

            Console.Write("Input a number for plumbus to view a detailed info: ");

            Console.Clear();

            int plumbusToPrint = int.Parse(Console.ReadLine());
            if (plumbusToPrint > PlumbusBoxList.Count || plumbusToPrint == 0) { SpecificPlumbusPrint(); }

            PlumbusBoxList[plumbusToPrint - 1].PrintInfo();

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            Console.Clear();

            Menu.MainMenu();
        }
    }

    public class Plumbus
    {
        public Plumbus() { }

        public Plumbus(string model, decimal price, string plumbusID,
            bool certificate, DingleBop dingle, Chumble chumble, Grumbo grumbo, Grodus grodus)
        {
            // Setting the value of the field "Weight" with a method using.
            WeightSetting();

            Model = model;

            Price = price;

            PlumbusID = plumbusID;

            GovermentCertificateIsAvailable = certificate;

            // Floob colour is one for all by default.
            FloobColour = "Pink";

            Dingle = dingle;

            CuriousChumble = chumble;

            MaterializedGrumb = grumbo;

            VisibleGrodus = grodus;
        }

        public double Weight { get; private set; }

        public string Model { get; private set; }

        public decimal Price { get; private set; }

        public string PlumbusID { get; private set; }

        public bool GovermentCertificateIsAvailable { get; private set; } = false;

        public string FloobColour { get; private set; }

        public DingleBop Dingle { get; private set; }

        public Chumble CuriousChumble { get; private set; }

        public Grumbo MaterializedGrumb { get; private set; }

        public Grodus VisibleGrodus { get; private set; }


        public class DingleBop
        {
            public DingleBop(double smildgeSpeed = 10, double flurbJurbLubricatorConsumption = 40)
            {
                SmildgeSpeed = smildgeSpeed;

                FlurbJurbLubricatorConsumption = flurbJurbLubricatorConsumption;
            }

            public double SmildgeSpeed { get; set; }

            public double FlurbJurbLubricatorConsumption { get; set; }

            public override string ToString()
            {
                return $"Dingle-bop info:\n" +
                    $"  Smilge speed: {SmildgeSpeed} microsept/ms\n" +
                    $"  Flur-jurb lubricator consumption: {FlurbJurbLubricatorConsumption} nanoglar/sec";
            }

            // For "Just in case".
            public void PrintInfo()
            {
                Console.WriteLine("Dingle-bop info:");
                Console.WriteLine($"    Smilge speed: {SmildgeSpeed} microsept/ms");
                Console.WriteLine($"    Flur-jurb lubricator consumption: {FlurbJurbLubricatorConsumption} nanoglar/sec;");
            }
        }

        public class Chumble
        {
            public Chumble(double length = 18, int chumblesCount = 17)
            {
                Length = length;

                CountOfChumbleFlagellums = chumblesCount;
            }

            public double Length { get; set; }

            public int CountOfChumbleFlagellums { get; set; }

            public void PrintInfo()
            {
                Console.WriteLine("Chumble info:");
                Console.WriteLine($"    Length: {Length} mm");
                Console.WriteLine($"    Count of the chumble flagellums: {CountOfChumbleFlagellums} pcs");
            }

            public override string ToString()
            {
                return $"Chumble info:\n" +
                    $"  Length: {Length} mm\n" +
                    $"  Count of chumble flagellums: {CountOfChumbleFlagellums} pcs";
            }
        }

        public class Grumbo
        {
            public Grumbo(double diameter = 120, double thickness = 52)
            {
                Diameter = diameter;

                Thickness = thickness;
            }

            public double Diameter { get; set; }

            public double Thickness { get; set; }

            // For "Just in case".
            public void PrintInfo()
            {
                Console.WriteLine("Grumb info:");
                Console.WriteLine($"    Diameter: {Diameter} mm");
                Console.WriteLine($"    Thickness: {Thickness} mm");
            }

            public override string ToString()
            {
                return $"Grumb info:\n" +
                    $"  Diameter: {Diameter} mm\n" +
                    $"  Thickness: {Thickness} mm";
            }
        }

        public class Grodus
        {
            public Grodus()
            {
                Length = 70;

                Diameter = 20;
            }
            public double Length { get; set; }

            public double Diameter { get; set; }

            // For "Just in case".
            public void PrintInfo()
            {
                Console.WriteLine("Grodus info:");
                Console.WriteLine($"    Length: {Length} mm");
                Console.WriteLine($"    Diameter: {Diameter} mm");
            }
            public override string ToString()
            {
                return $"Grodus info:\n" +
                    $"  Length: {Length} mm\n" +
                    $"  Diameter: {Diameter} mm";
            }
        }

        // New user plumbus's input.
        public static void InputNewPlumbus()
        {
            Console.WriteLine("You are creating a new university for storing plumbus.\n" +
                "Please, input your plumbus's data");

            Console.WriteLine();

            //Plumbus tempPlumbus = new Plumbus();

            Console.Write("Model (string): ");
            string model = Console.ReadLine();

            Console.Write("ID (string): ");
            string plumbusID = Console.ReadLine();

            Console.Write("Price (decimal): ");
            decimal price = decimal.Parse(Console.ReadLine());

            Console.Write("Cerficate (\"true\" or \"false\"): ");
            bool govermentCertificateIsAvailable = bool.Parse(Console.ReadLine());

            Console.WriteLine("Dingle-bop info:");

            Console.Write("    Smilge speed, microsept/ms (double): ");

            double smildgeSpeed = double.Parse(Console.ReadLine());

            Console.Write("    Flur-jurb lubricator consumption, nanoglar/sec (double): ");
            double flurbJurbLubricatorConsumption = double.Parse(Console.ReadLine());


            Console.WriteLine("Chumble info:");

            Console.Write("    Length, mm (double): ");
            //tempPlumbus.CuriousChumble.Length = double.Parse(Console.ReadLine());
            double curiousChumbleLength = double.Parse(Console.ReadLine());

            Console.Write("    Count of the chumble flagellums, pcs (int): ");
            int countOfChumbleFlagellums = int.Parse(Console.ReadLine());


            Console.WriteLine("Grumbo info:");

            Console.Write("    Diameter, mm (double): ");
            double materializedGrumbDiameter = double.Parse(Console.ReadLine());

            Console.Write("    Thickness, mm (double): ");
            double materializedGrumbThickness = double.Parse(Console.ReadLine());


            Console.WriteLine("Grodus info:");

            Console.Write("    Length, mm (double): ");
            double visibleGrodusLength = double.Parse(Console.ReadLine());

            Console.Write("    Diameter, mm (double): ");
            double visibleGrodusDiameter = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");

            PlumbusBox.Add
                (
                new Plumbus
                (
                    model,
                    price,
                    plumbusID,
                    govermentCertificateIsAvailable,
                    new DingleBop(smildgeSpeed, flurbJurbLubricatorConsumption),
                    new Chumble(curiousChumbleLength, countOfChumbleFlagellums),
                    new Grumbo(materializedGrumbDiameter, materializedGrumbThickness),
                    new Grodus()));

            Console.ReadKey();
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"ID: {PlumbusID}");
            Console.WriteLine($"Price: {Price} bryabls");
            Console.WriteLine("Cerficate: {0}", (GovermentCertificateIsAvailable ? "Available" : "Lost"));
            Console.WriteLine($"Floob colour: {FloobColour}");
            Console.WriteLine(Dingle.ToString());
            Console.WriteLine(CuriousChumble.ToString());
            Console.WriteLine(MaterializedGrumb.ToString());
            Console.WriteLine(VisibleGrodus.ToString());
        }

        
        // Random increment of the weight in case of using plumbus.
        public void Use()
        {
            Random random = new Random();
            Weight *= (random.NextDouble() + 1);
        }

        // Crankshaft rolling to set plumbus's weight in default value.
        public void WeightSetting()
        {
            Weight = Math.PI;
        }
    }
}


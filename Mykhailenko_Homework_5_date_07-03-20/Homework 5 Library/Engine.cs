using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5_Library
{
    public class Engine
    {
        static int[][,] savedMatrixesArray = new int[0][,];
        public static void MainMenu()
        {
            Console.Clear();

            Console.WriteLine("Welcome to main menu.");
            Console.WriteLine("Choose your option:\n");

            Console.WriteLine(" -  New matrix input.");
            Console.WriteLine(" -  Overview list with all saved matrixes.");
            Console.WriteLine(" -  Print detailed info for a matrix, selected from the list.");
            Console.WriteLine(" -  Transpose a matrix, selected from the list.");
            Console.WriteLine(" -  Quit.");

            Console.WriteLine();

            Console.Write("Choose your option (N/O/P/T/Q): ");

            ConsoleKeyInfo keyInfo = Console.ReadKey();

            // User's menu cases.
            // New matrix Input.
            if (keyInfo.Key == ConsoleKey.N) { Console.Clear(); NewMatrixInput(); }


            // Overwiev all matrixes.
            else if (keyInfo.Key == ConsoleKey.O)
            {
                Console.Clear();

                SavedMatrixesOverwiev();

                Console.WriteLine();

                Console.WriteLine("Press any key to return to main menu.");

                Console.ReadKey();
            }

            // Choose a matrix to print detailed info.
            else if (keyInfo.Key == ConsoleKey.P)
            {
                SelectedMatrixDetailedPrint();

                Console.WriteLine("Press any key to return to main menu.");

                Console.ReadKey();
            }

            //Choose a matrix to transpose.
            else if (keyInfo.Key == ConsoleKey.T)
            {
                SelectedMatrixTransposing();

                Console.WriteLine();

                Console.WriteLine("Press any key to return to main menu.");

                Console.ReadKey();
            }
            else if (keyInfo.Key == ConsoleKey.Q) { Console.Clear(); return; }


            // If incorrect key.
            else { Console.Clear(); MainMenu(); }

            MainMenu();
        }


        static void NewMatrixInput()
        {
            Console.WriteLine("New matrix input.\n");
            Console.WriteLine("Input your matrix's dimension: ");

            int arrayDimension = Validation.InputCheck();

            // Creating a new array to fill.
            int[,] newArray = new int[arrayDimension, arrayDimension];



            // Filling new array with a random nums.
            Random random = new Random();

            for (int i = 0; i < arrayDimension; i++)
            {
                for (int j = 0; j < arrayDimension; j++)
                {
                    newArray[i, j] = random.Next(0, 100);
                }
            }


            // Transforming current matrix into a triangle matrix
            ConsoleKeyInfo keyInfo = Validation.YesNoInputCheck("Is it a triangle matrix? (Y/N): ");

            if (keyInfo.Key == ConsoleKey.N) { LineOperations.LineClear(); }
            else
            {
                keyInfo = Validation.YesNoInputCheck("Is it an upper triangle matrix? (Y/N): ");

                // Refilling lower part of upper triangle matrix with "0"
                if (keyInfo.Key == ConsoleKey.Y)
                {
                    for (int i = 0; i < arrayDimension; i++)
                    {
                        for (int j = 0; j < arrayDimension; j++)
                        {
                            if (j < i)
                            {
                                newArray[i, j] = 0;
                            }
                        }
                    }
                }

                // Refilling upper part of lower triangle matrix with "0"
                else
                {
                    for (int i = 0; i < arrayDimension; i++)
                    {
                        for (int j = 0; j < arrayDimension; j++)
                        {
                            if (j > i)
                            {
                                newArray[i, j] = 0;
                            }
                        }
                    }
                }
            }


            Console.WriteLine("Your matrix:\n");

            MatrixPrint(newArray);

            Console.WriteLine();
            keyInfo = Validation.YesNoInputCheck("Save this matrix? (Y/N): ");

            if (keyInfo.Key == ConsoleKey.N) { LineOperations.LineClear(); }

            else { LineOperations.LineClear(); MatrixSave(newArray); }
        }

        static void MatrixSave(int[,] newArray)
        {
            Array.Resize(ref savedMatrixesArray, savedMatrixesArray.Length + 1);

            savedMatrixesArray[savedMatrixesArray.Length - 1] = newArray;

            Console.WriteLine("Matrix saving was succesfull. Press any key to continue.");

            Console.ReadKey();
        }

        static void MatrixPrint(int[,] selectedMarix)
        {
            int matrixDimensionLength = (int)Math.Sqrt(selectedMarix.Length);

            for (int i = 0; i < matrixDimensionLength; i++)
            {

                for (int j = 0; j < matrixDimensionLength; j++)
                {
                    Console.Write($"{selectedMarix[i, j],3}");
                }

                Console.WriteLine();
            }
        }

        static void SavedMatrixesOverwiev()
        {
            Console.WriteLine("Your saved matrixes:\n");

            if (savedMatrixesArray.Length == 0)
            {
                Console.WriteLine("No saved matrixes for now.");
            }

            for (int i = 0; i < savedMatrixesArray.Length; i++)
            {
                Console.WriteLine($"{$"Matrix #{i + 1}",12}. Dimensions: {Math.Sqrt(savedMatrixesArray[i].Length)} x {Math.Sqrt(savedMatrixesArray[i].Length)}");
            }
        }

        static void SelectedMatrixDetailedPrint()
        {
            Console.Clear();

            // Showing list with matrixes to user.
            SavedMatrixesOverwiev();

            Console.WriteLine();

            if (savedMatrixesArray.Length == 0)
            {
                Console.WriteLine("No matrixes to choose.\n");

                return;
            }

            // Asking user to select matrix by num entering.
            Console.Write("Input a number of a desired matrix for detailed info: ");

            string selectedMatrix = Console.ReadLine();
            LineOperations.LineClear();

            if ((int.TryParse(selectedMatrix, out int res) && (res > 0) && (res <= savedMatrixesArray.Length)))
            {
                Console.Clear();

                Console.WriteLine($"Detailed info about matrix #{savedMatrixesArray[res - 1]}\n");
                MatrixPrint(savedMatrixesArray[res - 1]);
            }

            else
            {
                Console.Clear();

                Console.WriteLine("Wrong input!\n");
                Console.WriteLine("Please input a number of the matrix from the list.");
                Console.WriteLine("Press any key to retirn to list.");

                Console.ReadKey();

                SelectedMatrixDetailedPrint();
            }

            Console.WriteLine();
        }

        static void SelectedMatrixTransposing()
        {
            Console.Clear();

            SavedMatrixesOverwiev();

            // Message for no matrixes have been saved.
            if (savedMatrixesArray.Length == 0)
            {
                Console.WriteLine("No matrixes to choose.\n");

                return;
            }

            Console.WriteLine();

            Console.Write("Input a number of a desired matrix to transpose: ");

            string selectedMatrix = Console.ReadLine();

            Console.Clear();


            // Checking the inputed matrix number.
            if ((int.TryParse(selectedMatrix, out int res) && (res > 0) && (res <= savedMatrixesArray.Length)))
            {
                Console.WriteLine("Original matrix:\n");

                MatrixPrint(savedMatrixesArray[res - 1]);
                Console.WriteLine();

                Transpose(savedMatrixesArray[res - 1]);

                Console.WriteLine("Transposed matrix:\n");
                MatrixPrint(savedMatrixesArray[res - 1]);

                Console.WriteLine("Matrix was updated in the saves list.");
            }

            else
            {
                Console.Clear();

                Console.WriteLine("Wrong input!\n");
                Console.WriteLine("Please input a number of the matrix from the list.");
                Console.WriteLine("Press any key to retirn to list.");

                Console.ReadKey();

                SelectedMatrixTransposing();
            }


            void Transpose(int[,] selectedArray)
            {
                int matrixDimension = (int)Math.Sqrt(selectedArray.Length);

                for (int i = 0; i < matrixDimension; i++)
                {
                    //int[] transpositionArray = new int[matrixDimension-i];
                    int transpositionNum;

                    for (int j = i; j < matrixDimension; j++)
                    {
                        transpositionNum = selectedArray[i, j];
                        selectedArray[i, j] = selectedArray[j, i];
                        selectedArray[j, i] = transpositionNum;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

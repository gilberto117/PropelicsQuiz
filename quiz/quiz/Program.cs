using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz
{
    class Program 
    {
        static void Main(string[] args)
        {
            int Option;
            try
            {
                do
                {
                    Console.WriteLine("1.   Calculate Angle");
                    Console.WriteLine("2.   Anagram Validator");
                    Console.WriteLine("3.   Compression String");
                    Console.WriteLine("4.   SwapTwoIntegers");
                    Console.WriteLine("5.   Covert Rows Matrix");
                    Console.WriteLine("0.   Exit");
                    Console.Write("Select an option:");
                    Option = int.Parse(Console.ReadLine());
                    Test objTest = new Test();
                    switch (Option)
                    {
                        case 1:
                            int Hour;
                            Console.Write("Insert The Hour:");
                            Hour = int.Parse(Console.ReadLine());
                            int Minute;
                            Console.Write("Insert The Minute:");
                            Minute = int.Parse(Console.ReadLine());
                            float Angle = objTest.CalculateAngle(Hour, Minute);
                            Console.Write("The Angle Is: {0}", Angle);
                            Console.ReadLine();
                            break;
                        case 2:
                            string FirtsString, SecondString;
                            Console.Write("Insert The First String:");
                            FirtsString = Console.ReadLine();
                            Console.Write("Insert The Second String:");
                            SecondString = Console.ReadLine();
                            bool Result = objTest.AnagramValidator(FirtsString, SecondString);
                            Console.Write("The Result Is: {0}", Result);
                            Console.ReadLine();
                            break;
                        case 3:
                            string OriginalString;
                            Console.Write("Insert The Input String:");
                            OriginalString = Console.ReadLine();
                            string StringResult = objTest.CompressionString(OriginalString);
                            Console.Write("The Compressed String Is: {0}", StringResult);
                            Console.ReadLine();
                            break;
                        case 4:
                            int FirstInput, SecondInput;
                            Console.Write("Insert The First Input:");
                            FirstInput = int.Parse(Console.ReadLine());
                            Console.Write("Insert The Second Input:");
                            SecondInput = int.Parse(Console.ReadLine());
                            int[] ResultNumber = objTest.SwapNumbers(FirstInput, SecondInput);
                            Console.Write("The Result Is: {0}, {1}", ResultNumber[0], ResultNumber[1]);
                            Console.ReadLine();
                            break;
                        case 5:
                            int Rows, Columns;
                            do
                            {
                                Console.Write("Insert The Number Of Rows In Matrix:");
                                Rows = int.Parse(Console.ReadLine());
                            } while (Rows <= 1);

                            do
                            {
                                Console.Write("Insert The Number Of Columns In Matrix:");
                                Columns = int.Parse(Console.ReadLine());
                            } while (Columns <= 1);
                            
                            int[,] InputMatrx = new int[Rows, Columns];

                            Console.Write("Insert The Elements In The Matrix :\n");
                            for (int i = 0; i < Rows; i++)
                            {
                                for (int j = 0; j < Columns; j++)
                                {
                                    Console.Write("Element - [{0},{1}] : ", i, j);
                                    InputMatrx[i, j] = Convert.ToInt32(Console.ReadLine());
                                }
                            }
                            int[,] OuputMatrix = objTest.ConvertRowsMatrix(InputMatrx, Rows, Columns);

                            Console.WriteLine("\nThe Final Matrix Is : ");
                            for (int i = 0; i < Rows; i++)
                            {
                                Console.WriteLine("");
                                for (int j = 0; j < Columns; j++)
                                {
                                    Console.Write("{0}\t", OuputMatrix[i, j]);
                                }
                                    
                            }
                            Console.WriteLine("");
                            Console.ReadLine();

                            break;
                        case 0:
                            break;

                    }
                } while (Option != 0);
            }
            catch (Exception)
            {
                Console.Write("You Inserted An Incompatible Data: FATAL ERROR");
                Console.ReadLine();
            }
           
            
        }
    }
}

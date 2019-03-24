using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz
{
    class Test : Questions
    {
        //Write a function that receives an hour and a minute from an analog clock and calculates the inner angle between them.
        public float CalculateAngle(int hour, int minute)
        {
            float Angle = 0;
            try
            {
                const int MaxMinutes = 60, MaxHours = 12, MaxGrades = 360;

                if(hour == 0)
                {
                    hour = 12;
                }
                if(minute == 0)
                {
                    minute = 60;
                }

                float GradesMin = (minute * MaxGrades) / MaxMinutes;
                float GradesHour = (hour * MaxGrades) / MaxHours;

                if (GradesMin > GradesHour)
                {
                    Angle = GradesMin - GradesHour;
                }
                else
                {
                    Angle = GradesHour - GradesMin;
                }

                return Angle;

            }
            catch (Exception)
            {
                return Angle;
            }
            
           
        }

        //Write a function that, given two strings, test whether one is an anagram of the other.
        public bool AnagramValidator(string FirtsString, string SecondString)
        {
            try
            {

                char[] ArrOne = FirtsString.ToUpper().ToArray();
                char[] ArrTwo = SecondString.ToUpper().ToArray();

                Array.Sort(ArrOne);
                Array.Sort(ArrTwo);

                string FirtsStringOrdered = new string(ArrOne);
                string SecondOrdered = new string(ArrTwo);

                if(FirtsStringOrdered.Equals(SecondOrdered))
                {
                    return true;
                }
                else
                {
                    return false;
                }
               
                
            }
            catch (Exception)
            {

                return false;
            }
           
        }

        /*Write a function to perform basic string compression using the counts of repeated characters;
        e.g. "aabcccccaaa" would become "a2b1c5a3". If the compressed string would not become
        smaller than the original string, just print the original string. */
        public string CompressionString(string OriginalString)
        {
            try
            {
                char[] CharString = OriginalString.ToArray();
                List<char> ResultString = new List<char>();
                int Index = 0;
                do
                {
                    char Character = CharString[Index];
                    int CountSimilarChar = 0;
                    ResultString.Add(Character);
                    
                    while(Index < CharString.Length && Character == CharString[Index])
                    {
                        CountSimilarChar++;
                        Index++;
                    }
                    ResultString.Add(char.Parse(CountSimilarChar.ToString()));
                } while (Index < CharString.Length);

                StringBuilder builder = new StringBuilder();
                foreach (char character in ResultString)
                {
                    builder.Append(character);
                }
                return builder.ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            
        }

        //Swap two integers without using a temporary variable.
        public int[] SwapNumbers(int FirtsInput, int SecondInput)
        {
            int[] SwapedNumbers = new int[2];
            try
            {
                FirtsInput = FirtsInput + SecondInput;
                SecondInput = FirtsInput - SecondInput;
                FirtsInput = FirtsInput - SecondInput;
                SwapedNumbers[0] = FirtsInput;
                SwapedNumbers[1] = SecondInput;
                return SwapedNumbers;
            }
            catch (Exception)
            {
                SwapedNumbers[0] = -1;
                SwapedNumbers[1] = -1;
                return SwapedNumbers;
            }
           
        }


        /*Write a function such that if an element in an MxN matrix is 0, its entire row and column are set
        to 0 and then printed out.*/
        public int[,] ConvertRowsMatrix(int[,] InputMatrix, int Rows, int Columns)
        {

            int[,] ResultMatrix = new int[Rows, Columns];

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    ResultMatrix[i, j] = InputMatrix[i, j];
                }
            }

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {

                    if (InputMatrix[i, j] == 0)
                    {
                        for (int i2 = 0; i2 < Rows; i2++)
                        {
                            ResultMatrix[i2, j] = 0;
                        }
                        for (int j2 = 0; j2 < Columns; j2++)
                        {
                            ResultMatrix[i, j2] = 0;
                        }
                    }
                    

                }

            }
            return ResultMatrix;
        }
    }
}

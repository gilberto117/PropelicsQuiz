using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz
{
    interface Questions
    {
        //Write a function that receives an hour and a minute from an analog clock and calculates the inner angle between them.
        float CalculateAngle(int hour, int minute);

        //Write a function that, given two strings, test whether one is an anagram of the other.
        bool AnagramValidator(string firtsString, string secondString);

        /*Write a function to perform basic string compression using the counts of repeated characters;
        e.g. "aabcccccaaa" would become "a2b1c5a3". If the compressed string would not become
        smaller than the original string, just print the original string. */
        string CompressionString(string OriginalString);

        //Swap two integers without using a temporary variable.
        int[] SwapNumbers(int FirtsInput, int SecondInput);

        /*Write a function such that if an element in an MxN matrix is 0, its entire row and column are set
        to 0 and then printed out.*/
        int[,] ConvertRowsMatrix(int[,] InputMatrix, int Rows, int Columns);
        

    }
}

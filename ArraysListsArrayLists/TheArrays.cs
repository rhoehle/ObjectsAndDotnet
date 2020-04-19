using System;
using System.Collections.Generic;
using System.Text;

namespace ArraysListsArrayLists
{
    // dataType[] arrayName = new dataType[amountOfEntries];
    class TheArrays
    {
        static void Main(string[] args)
        {
            int[] randomnIntsInAnArray = new int[] { 77, 33, 54, 23, 66, 99, 667, 24456, 34, 5, 22 };
            Console.WriteLine(randomnIntsInAnArray.Length);

            // Two dim [,] arrays -> matrix -> rows/colums
            int[,] twoDimensionalArray = new int[,]
            {
                { 1,2,3},
                { 4, 5, 6},
                { 7, 8, 9}
            };
            Console.WriteLine("Central value = " + twoDimensionalArray[1,1]);
            Console.ReadKey();
        }


    }
}

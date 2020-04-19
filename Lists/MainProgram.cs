using System;
using System.Collections.Generic;

namespace ArrayListsAndLists

{
    class MainProgram
    {
        static void Main(string[] args)
        {
            int[] scores = new int[] { 24, 66, 88, 74, 1 };

            // can search and sort lists and many other methods/properties
            List<int> list = new List<int> { 1, 2, 3, 4 };
            int last = list.FindLast(x => x.ToString());

         }
    }
}

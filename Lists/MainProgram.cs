using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace ArrayListsAndLists

{
    class MainProgram
    {
        static void Main(string[] args)
        {
            int[] scores = new int[] { 24, 66, 88, 74, 1 };

            // can search and sort lists and many other methods/properties
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 9, 1, 77,  };
            // finds the last element's index position based on the search criteria
            int findValue = list.FindLastIndex(x => x >3);
            Console.WriteLine("findValue = {0}", findValue);
            Console.WriteLine();

            List<int> testList = new List<int> { 3, 5, 6, 87, 4032, 0, 3, 5, 99, 1099 };
            testList.Add(403);
            testList.Add(999);

            Console.WriteLine("For each value in testList write it once.");
            foreach (var i in testList)
            {
                Console.WriteLine(i);
            }
            //var output = new StringConverter().ConvertFrom(List<int>(testList));
            //Console.WriteLine(output);

            testList.Sort();
            Console.WriteLine("Now sorted.");
            testList.ForEach(element => Console.WriteLine(element));

            ArrayList workingArrayList = new ArrayList();
            workingArrayList.Add("Beanhole");
            workingArrayList.Add(69);
            workingArrayList.Add("Even standards have standards.");
            workingArrayList.Add(99);
            workingArrayList.Add(new object());

            foreach (var workingArrayItem in workingArrayList)
            {
                Console.WriteLine(workingArrayItem);
            }

            Console.ReadKey();

         }
    }
}

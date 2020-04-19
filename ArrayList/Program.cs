using System;
using System.Collections;

namespace DemoArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myFunkyArray = new ArrayList();

            myFunkyArray.Add("Added string");
            myFunkyArray.Add(35.44);
            myFunkyArray.Add(76);
            myFunkyArray.Add(999);
            myFunkyArray.Add("This is the end of the array!");

            Console.WriteLine("Amount of elements in the array = " + myFunkyArray.Count);

            double sum = 0;

            foreach (object itemInArray in myFunkyArray)
            {
                if (itemInArray is int)
                {
                    sum += Convert.ToDouble(itemInArray);
                }
                else if(itemInArray is double)
                {
                    sum += (double)itemInArray;
                }
                else if(itemInArray is string)
                {
                    Console.WriteLine(itemInArray);
                }
            }
            Console.WriteLine("Sum of the items in the array = " + sum);
            Console.ReadKey();
        }
    }
}

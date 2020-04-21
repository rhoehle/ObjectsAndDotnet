using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 15, 22 };

            OddNumbers(numbers);
            Console.ReadKey();
        }

        static void OddNumbers(int[] numbers)
        {
            Console.WriteLine("Odd numbers:  ");
            IEnumerable<int> oddNumbers = from number in numbers where number % 2 != 0 select number;
            Console.WriteLine(oddNumbers);

            foreach (var i in oddNumbers)
            {
                Console.WriteLine(i);
            }
        }

    }
}

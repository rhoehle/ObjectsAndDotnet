using System;

namespace EventsAndDelegates
{
    class Program
    {
        public delegate double PerformCalculation(double firstVar, double secondVar);

        public static double Addition(double methodVarOne, double methodVarTwo)
        {
            Console.WriteLine("methodVarOne + methodVarTwo = " + (methodVarOne + methodVarTwo));
            return methodVarOne + methodVarTwo;
        }
        public static double Divide(double methodVarOne, double methodVarTwo)
        {
            Console.WriteLine("methodVarOne / methodVarTwo = " + (methodVarOne / methodVarTwo));
            return methodVarOne / methodVarTwo;
        }

        static void Main(string[] args)
        {
            // point at a method
            PerformCalculation getSum = Addition;
            getSum(7.6, 8.5);

            PerformCalculation getDivided = Divide;
            getDivided(25, 5);

            // multi-cast delegate -> useful to trigger multiple calculation with events
            PerformCalculation multipleCalculation = getSum + getDivided;
            multipleCalculation(99, 100.2);
        }
    }
}

using System;

namespace LambdaExpressions
{
    class Program
    {
        public delegate string GetTextDelegate(string name);

        public delegate double GetResultDelegate(double numberOne, double numberTwo);

        public delegate double GetProductDelegate(double productOne, double productTwo);

        static void Main(string[] args)
        {
            // Anonymous method, aka in-line delegate
            GetTextDelegate getTextDelegate = delegate (string name)
            {
                return "Hello from the GetTextDelegate made by " + name;
            };

            // Expression Lambda
            GetTextDelegate getHelloText = (string name) => { return "Hello, " + name; };

            // Statement Lambda
            GetTextDelegate getGoodbyeText = (string name) =>
            {
                Console.WriteLine("I'm inside of a statement Lambda");
                return "Goodbye, " + name;
            };

            // Real used Lambda's, shortened Lambda
            GetTextDelegate getWelcomeText = name => "Welcome, to real Lambdas " + name;
            GetResultDelegate getSum = (a, b) => a + b;
            GetResultDelegate getProduct = (c, d) => c * d;
            DisplaySum(getSum);
            DisplaySum(getProduct);

            Console.WriteLine(getWelcomeText("Rob"));

        }
        static void DisplayProduct(GetProductDelegate getProductDelegate)
        {
            Console.WriteLine(getProductDelegate(30, 4));
        }

        static void DisplaySum(GetResultDelegate getResultDelegate)
        {
            Console.WriteLine(getResultDelegate(6.6, 4.5));
        }

        static void Display(GetTextDelegate getTextDelegate)
        {
            Console.WriteLine(getTextDelegate("Another Rob!"));
        }
    }
}

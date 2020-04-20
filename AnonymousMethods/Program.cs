using System;

namespace AnonymousMethods
{
    class Program
    {
        public delegate string GetTextDelegate(string name);
        static void Main(string[] args)
        {
            // Anonymous method, aka in-line delegate
            GetTextDelegate getTextDelegate = delegate (string name)
            {
                return "Hello from the GetTextDelegate made by " + name;
            };
            Console.WriteLine(getTextDelegate("Rob."));
            Display(getTextDelegate);
        }
        static void Display(GetTextDelegate getTextDelegate)
        {
            Console.WriteLine(getTextDelegate("Another Rob!"));
        }

        // methods run first
        public static void SayHi()
        {
            Console.WriteLine("Hi");
        }
    }
}

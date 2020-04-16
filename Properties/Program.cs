using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box(55, 66, 77);
            Console.WriteLine("Height = " + box.Height);
            box.DisplayInfo();
        }
    }
}

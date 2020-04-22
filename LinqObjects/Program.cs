using System;

namespace LinqObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            UniversityManager um = new UniversityManager();

            um.MaleStudents();
            Console.WriteLine();
            um.FemaleUnder22();

            Console.ReadKey();
        }
    }
}

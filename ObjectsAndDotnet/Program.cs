using System;

namespace ObjectsAndDotnet
{
    class Program

    {
        static void Main(string[] args)
        {
            Animal baseAnimal = new Animal();

            Animal dog = new Animal("German Shepherd", 42);
            dog.AnimalDescription();

            Animal skunk = new Animal("Striped Skunk", 13);
            skunk.AnimalDescription();

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectsAndDotnet
{

    class Animal
    {
        // Class/member Variables -> Fields
        private string animalName;
        private double animalWeight;

        // Object creation default constructor (automatically created)
        public Animal()
        {
            Console.WriteLine("Default constructor (automatically created by the compiler)");
        }

        // Constructor
        public Animal(string animalName, double animalWeight)
        {
            this.animalName = animalName;
            this.animalWeight = animalWeight;
        }
        
        // Member method
        public void AnimalDescription()
        {
            Console.WriteLine("This animal is a {0} and weighs {1} pounds.", animalName, animalWeight);
        }
    }
}

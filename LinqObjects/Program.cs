﻿using System;

namespace LinqObjects
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        // foreign key
        public int UniversityId { get; set; }

        public void Print()
        {
            Console.WriteLine("Student {0} with Id {1}, Gender {2} and Age {3} from University with the Id {4}.", Name, Id, Gender, Age, UniversityId);
        }
    }

}

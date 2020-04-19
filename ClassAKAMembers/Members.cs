using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAKAMembers
{
    class Members
    {

        private string memberName;
        private string jobTitle;
        private double salary;
        public int age;

       // public string JobTitle { get; set; }

        public void PersonalInformation(bool isConfidant)
        {
            if (isConfidant)
            {
                ConfidantInfo();
            }
            else
            {
                Console.WriteLine("You do not have sufficient privledges {0}, but my job title is {1}, and I am {2} years old.", memberName, jobTitle, age);
            }
        }

        private void ConfidantInfo()
        {
            Console.WriteLine("My salary is {0}.", salary);
        }

        // member/class constructor
        public Members()
        {
            age = 50;
            memberName = "SuperMan";
            salary = 250000.00;
            jobTitle = "Senior Develolper";
            Console.WriteLine("Constructor called, object initialted.");
        }

    }
}

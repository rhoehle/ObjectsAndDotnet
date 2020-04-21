using System;

namespace LinqObjects
{
    class University
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void PrintNameAndId()
        {
            Console.WriteLine("University {0} with Id of {1}", Name, Id );
        }
    }


}

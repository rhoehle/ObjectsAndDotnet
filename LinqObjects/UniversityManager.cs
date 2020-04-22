using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqObjects
{
    class UniversityManager
    {

        public List<University> universities;
        public List<Student> students;

        // Constructor
        public UniversityManager()
        {
            universities = new List<University>();
            students = new List<Student>();

            // Add universities
            universities.Add(new University { Id = 1, Name = "Yale" });
            universities.Add(new University { Id = 2, Name = "College of Eastern Utah" });
            universities.Add(new University { Id = 3, Name = "Drake" });
            universities.Add(new University { Id = 4, Name = "University of Utah" });

            // Add students
            students.Add(new Student { Id = 1, Name = "Dave Rogers", Gender = "Male", Age = 22, UniversityId = 4 });
            students.Add(new Student { Id = 2, Name = "Callie Callor", Gender = "Female", Age = 22, UniversityId = 2 });
            students.Add(new Student { Id = 3, Name = "Bird Man", Gender = "Male", Age = 47, UniversityId = 4 });
            students.Add(new Student { Id = 4, Name = "Robert Hoehle", Gender = "Male", Age = 50, UniversityId = 3 });
            //students.Append(Student { Id = 4, Name = "Robert Hoehle", Gender = "Male", Age = 50, UniversityId = 2 });
            // How would you add multiple University Id's to one student?
            students.Add(new Student { Id = 5, Name = "Kathy Penovich", Gender = "Female", Age = 32 });
            students.Add(new Student { Id = 6, Name = "Kevin Hod", Gender = "Male", Age = 28 });
            students.Add(new Student { Id = 7, Name = "Leah Boyach", Gender = "Female", Age = 17 });
        }

        public void MaleStudents()
        {
            IEnumerable<Student> maleStudents = from student in students where student.Gender == "Male" select student;
            Console.WriteLine("Male - Students: ");

            foreach (var students in maleStudents)
            {
                students.Print();
            }
        }

        public void FemaleUnder22()
        {
            IEnumerable<Student> femaleStudentsUnder23 = from student in students where student.Gender == "Female" +
                                                         "" && student.Age < 23 select student;
            Console.WriteLine("Female Students under 23: ");

            foreach (var student in femaleStudentsUnder23)
            {
                student.Print();
            }

        }

        public void StudentAndUniversityNameCollection()
        {
            var newCollection = from student in students
                                join university in universities on student.UniversityId equals university.Id
                                orderby student.Name
                                select new { StudentName = student.Name, UniversityName = university.Name };

            Console.WriteLine("New collection: ");

            foreach (var col in newCollection)
            {
                Console.WriteLine("Student {0} from University {1}", col.StudentName, col.UniversityName);
            }
        }

    }
}

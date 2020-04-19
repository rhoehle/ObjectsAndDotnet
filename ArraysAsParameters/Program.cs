using System;

namespace ArraysAsParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] studentGrades = new int[] { 83, 94, 98, 100, 75, 67, 98 };
            double gradeAverage = GetAverageFromArray(studentGrades);
            Console.WriteLine("The average of the grades = " + gradeAverage);
            var testCounter = 1;
            foreach (var grade in studentGrades)
            {
                Console.WriteLine("Student test {0} grade is {1}", testCounter, grade);
                testCounter++;
            }
        }
        static double GetAverageFromArray(int[] numberContainer)
        {
            int sizeOfArray = numberContainer.Length;
            double average;
            int sum = 0;

            for (int i = 0; i < sizeOfArray; i++)
            {
                sum += numberContainer[i];
            }
            average = (double)sum / sizeOfArray;
            return average;
        }

    }
}

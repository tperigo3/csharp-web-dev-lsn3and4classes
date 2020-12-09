using System;

// Start working here with your Student class.
// To instantiate the Student class, add your code to the Main method in Program

namespace SchoolPractice
{
    public class Student
    {
        public string Name { get; set; }
        public int StudentID { get; set; }
        public int NumberofCredits { get; set; }
        public double Gpa { get; set; }

        public Student(int numberofCredits, double gpa)
        {
            NumberofCredits = numberofCredits;
            Gpa = gpa;

        }
    }
}

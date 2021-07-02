using System;
using System.Collections.Generic;
using System.Text;

namespace Students
{
    class StudentInfo
    {
        public StudentInfo(string firstName, string lastName, double grade) 
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:f2}";
        }
    }
}

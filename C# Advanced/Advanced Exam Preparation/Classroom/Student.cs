using System;
using System.Collections.Generic;
using System.Text;

namespace ClassroomProject
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private string subject;

        public string FirstName
        {
            get { return firstName; }
            private set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            private set { lastName = value; }
        }

        public string Subject
        {
            get { return subject; }
            private set { subject = value; }
        }


        public Student(string firstName, string lastName, string subject)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Subject = subject;
        }

        public override string ToString()
        {
            return $"Student: First Name = {this.FirstName}, Last Name = {this.LastName}, Subject = {this.Subject}";
        }
    }
}

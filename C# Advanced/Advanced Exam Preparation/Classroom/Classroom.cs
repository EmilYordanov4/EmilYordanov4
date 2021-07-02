using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassroomProject
{
    public class Classroom
    {
        private List<Student> students;
        private int capacity;
        public Classroom(int capacity)
        {
            this.Capacity = capacity;
            this.students = new List<Student>();
        }

        public int Capacity 
        {
            get { return capacity; }
            private set { capacity = value; }
        }


        public int Count => students.Count;

        public string RegisterStudent(Student student)
        {
            if (Count < Capacity)
            {
                students.Add(student);
                return $"Added student {student.FirstName} {student.LastName}";
            }
            else
            {
                return $"No seats in the classroom";
            }
        }

        public string DismissStudent(string firstName, string lastName)
        {
            Student student = students.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);

            if (student != null)
            {
                students.Remove(student);
                return $"Dismissed student {firstName} {lastName}";
            }
            else
            {
                return $"Student not found";
            }
        }

        public string GetSubjectInfo(string subject)
        {
            StringBuilder sb = new StringBuilder();
            var studentsWithSubject = students.Where(x => x.Subject == subject).ToList();


            if (studentsWithSubject.Count == 0)
            {
                sb.AppendLine($"No students enrolled for the subject");
                return sb.ToString().Trim();
            }

            sb.AppendLine($"Subject: {subject}");
            sb.AppendLine($"Students:");
            foreach (var item in studentsWithSubject)
            {
                sb.AppendLine($"{item.FirstName} {item.LastName}");
            }

            return sb.ToString().TrimEnd();
        }

        public int GetStudentsCount() 
        {
            return Count;
        }

        public Student GetStudent(string firstName, string lastName) 
        {
            Student student = students.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);

            return student;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;

namespace E04.Students
{
    class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split().ToArray();
                string firstName= tokens[0];
                string lastName= tokens[1];
                double grade=double.Parse( tokens[2]);

                Student student = new Student(firstName, lastName,grade );

                students.Add(student);

            }

            foreach (Student student1 in students.OrderByDescending(s => s.Grade))
            {
                Console.WriteLine($"{student1.FirstName} {student1.LastName}: {student1.Grade:F2}");
            }
        }
    }
}

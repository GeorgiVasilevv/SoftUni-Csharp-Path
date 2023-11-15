using System;
using System.Collections.Generic;
using System.Linq;

namespace E04.Students
{
    internal class Program
    {
        class Student
        {
            public Student(string FirstName, string LastName, int Age, string HomeTown)
            {
                this.firstName = FirstName;
                this.lastName = LastName;
                this.age = Age;
                this.homeTown = HomeTown;
            }
            public string firstName { get; set; }

            public string lastName { get; set; }

            public int age { get; set; }

            public string homeTown { get; set; }

        }
        static void Main(string[] args)
        {
            List<Student> people = new List<Student>();

            string cmd = Console.ReadLine();
            while (cmd != "end")
            {
                string[] tokens = cmd.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string firstName = tokens[0];
                string lastName = tokens[1];
                int age = int.Parse(tokens[2]);
                string homeTown = tokens[3];
                if (IsExisting(people, firstName, lastName))
                {
                    Student existingStudent = null;
                    foreach (Student student in people)
                    {
                        if (student.firstName == firstName && student.lastName == lastName)
                        {
                            existingStudent = student;
                        }
                    }
                    existingStudent.firstName = firstName;
                    existingStudent.lastName = lastName;
                    existingStudent.age = age;
                    existingStudent.homeTown = homeTown;
                }
                else
                {
                    Student student = new Student(firstName, lastName, age, homeTown);
                    people.Add(student);
                }

                cmd = Console.ReadLine();
            }
            string cityName = Console.ReadLine();
            List<Student> filteredStudents = people.Where(x => x.homeTown == cityName).ToList();
            foreach (var person in filteredStudents)
            {
                Console.WriteLine($"{person.firstName} {person.lastName} is {person.age} years old.");
            }
        }
        static bool IsExisting(List<Student> people, string firstName, string lastName)
        {
            foreach (var student in people)
            {
                if (student.firstName == firstName && student.lastName == lastName)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

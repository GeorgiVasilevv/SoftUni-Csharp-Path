using System;
using System.Collections.Generic;
using System.Linq;

namespace E02.AverageStudentGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] studentInfo = Console.ReadLine().Split();
                string studentName = studentInfo[0];
                decimal studentGrade = decimal.Parse(studentInfo[1]);

                if (!students.ContainsKey(studentName))
                {
                    students.Add(studentName, new List<decimal>());
                }
                students[studentName].Add(studentGrade);

            }

            foreach (var student in students)
            {

                Console.WriteLine($"{student.Key} -> {string.Join($" ", student.Value.Select(n => n.ToString("F2")))} (avg: {student.Value.Average():F2})");
                //Console.Write($"{student.Key} -> ");
                //foreach (var grades in student.Value)
                //{
                //    Console.Write($"{grades:f2} ");
                //}
                //Console.WriteLine($"(avg: { student.Value.Average():F2})");
            }


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace E06.Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            string cmd = Console.ReadLine();
            while (cmd!="end")
            {
                string[] tokens = cmd.Split(" : ").ToArray();
                string courseName = tokens[0];
                string studentName = tokens[1];

                if (courses.ContainsKey(courseName))
                {
                    courses[courseName].Add(studentName);
                }
                else
                {
                    courses.Add(courseName, new List<string>() { studentName });
                }
                cmd = Console.ReadLine();
            }
            foreach (var item in courses)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                foreach (var item2 in item.Value)
                {
                    Console.WriteLine($"-- {item2}");
                }
            }
        }
    }
}

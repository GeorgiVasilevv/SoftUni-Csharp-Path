using System;
using System.Collections.Generic;
using System.Linq;

namespace E07.StudentAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (students.ContainsKey(name))
                {
                    students[name].Add(grade);
                    
                }
                else
                {
                    students.Add(name, new List<double>() { grade });
                }
            }
            
            foreach (var item in students)
            {
                if (item.Value.Average() >= 4.5)
                {

                Console.WriteLine($"{item.Key} -> {item.Value.OrderByDescending(x=>x).Average():f2}");
                }

            }
        }
    }
}

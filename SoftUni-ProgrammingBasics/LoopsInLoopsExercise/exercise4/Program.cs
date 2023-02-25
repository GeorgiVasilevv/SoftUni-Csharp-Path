using System;

namespace exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string presentation = Console.ReadLine();
            double overallSum = 0;
            int counter = 0;
            while (presentation!="Finish")
            {
                double sum=0;
                double grades;

                for (int i = 0; i < n; i++)
                {
                    grades = double.Parse(Console.ReadLine());
                    sum += grades;
                    overallSum += grades;
                    counter++;

                }
                Console.WriteLine($"{presentation} - {(sum/n):f2}.");

                presentation = Console.ReadLine();
            }
            Console.WriteLine($"Student's final assessment is {(overallSum/counter):f2}.");
        }
    }
}

using System;

namespace _02.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            checkGrade(grade);
        }
        public static double checkGrade(double grade) 
        {
            switch (grade)
            {
                case >= 2.00 and < 3:
                    Console.WriteLine("Fail");
                    break;
                case >= 3 and <= 3.49:
                    Console.WriteLine("Poor");
                    break;
                case >= 3.50 and < 4.5:
                    Console.WriteLine("Good");
                    break;
                case >= 4.5 and < 5.5:
                    Console.WriteLine("Very good");
                    break;
                case >= 5.5 and <= 6.00:
                    Console.WriteLine("Excellent");
                    break;
            }
            return grade;
        }
    }
}

using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            int counter5 = 0;
            int counter4 = 0;
            int counter3 = 0;
            int counter2 = 0;
            double average = 0;

            for (int i = 0; i < students; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                average += grade;

                if (grade>=5.00)
                {
                    counter5++;
                }
                else if (grade>=4.00 && grade<=4.99 )
                {
                    counter4++; 
                }
                else if (grade >= 3 && grade <= 3.99)
                {
                    counter3++;
                }
                else if (grade <3)
                {
                    counter2++;
                }
            }
            Console.WriteLine($"Top students: {(counter5 / (double)students) * 100:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {(counter4 / (double)students) * 100:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {(counter3 / (double)students) * 100:f2}%");
            Console.WriteLine($"Fail: {(counter2 / (double)students) * 100:f2}%");
            Console.WriteLine($"Average: {average/students:f2}"
);
        }
    }
}

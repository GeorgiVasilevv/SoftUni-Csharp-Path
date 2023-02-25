using System;

namespace exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double N1 = double.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            char op = char.Parse(Console.ReadLine());
            string evenorodd = "";
            double result = 0;

            if (op == '+' || op == '-' || op == '*')
            {
                if (op == '+')
                {
                    result = N1 + N2;
                }
                else if (op == '-')
                {
                    result = N1 - N2;
                }
                else if (op == '*')
                {
                    result = N1 * N2;
                }
                if (result % 2 == 0)
                {
                    evenorodd = "even";
                }
                else
                {
                    evenorodd = "odd";
                }
                Console.WriteLine($"{N1} {op} {N2} = {result} - {evenorodd}");
            }
            else if (op == '/')
            {
                if (N2 != 0)
                {
                    result = N1 / N2;
                    Console.WriteLine($"{N1} / {N2} = {result:f2}");
                }
                else
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");
                }

            }
            else if (op == '%')
            {
                if (N2 != 0)
                {
                    result = N1 % N2;
                    Console.WriteLine($"{N1} % {N2} = {result}");
                }

                else
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");
                }
            }


        }

    }
}

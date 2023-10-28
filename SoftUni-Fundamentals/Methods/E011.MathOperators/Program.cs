using System;

namespace E011.MathOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            char @operator = char.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(CalculateNumbers(a,@operator,b));
        }
        public static double CalculateNumbers(int a, char @operator, int b)
        {
            double sum = 0;
            switch (@operator)
            {
                case '+':
                    sum = a + b;
                    break;
                case '/':
                    sum = a / b;
                    break;
                case '*':
                    sum = a * b;
                    break;
                case '-':
                    sum = a - b;
                    break;
                default:
                    break;
            }
            return sum;
        }
    }
}

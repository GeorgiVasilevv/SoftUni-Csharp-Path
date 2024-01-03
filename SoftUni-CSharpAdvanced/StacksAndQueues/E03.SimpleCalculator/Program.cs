using System;
using System.Collections.Generic;
using System.Linq;

namespace E03.SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Stack<string> stack = new Stack<string>(Console.ReadLine().Split().Reverse());

            int result = int.Parse(stack.Pop());

            while (stack.Count >= 1)
            {


                if (stack.Pop() == "+" )
                {
                    result += int.Parse(stack.Pop());

                }
                else
                {
                    result -= int.Parse(stack.Pop());

                }
            }
            Console.WriteLine(result);
        }
    }
}

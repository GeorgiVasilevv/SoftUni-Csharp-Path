using System;
using System.Collections.Generic;
using System.Linq;

namespace E02.StackSum
{
    
        internal class Program
        {
            static void Main(string[] args)
            {
                Stack<int> stack = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToList());
                string cmd = Console.ReadLine().ToLower();
                while (cmd != "end")
                {
                    string[] splitted = cmd.Split();
                    if (splitted[0] == "add")
                    {
                        int numOne = int.Parse(splitted[1]);
                        int numTwo = int.Parse(splitted[2]);

                        stack.Push(numOne);
                        stack.Push(numTwo);
                    }
                    else if (splitted[0] == "remove")
                    {
                        int number = int.Parse(splitted[1]);
                        if (number <= stack.Count())
                        {
                            for (int i = 0; i < number; i++)
                            {
                                stack.Pop();
                            }

                        }
                    }
                    cmd = Console.ReadLine().ToLower();
                }
                Console.WriteLine("Sum: " + stack.Sum());
            }
        }
    }


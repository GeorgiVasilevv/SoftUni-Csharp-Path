using System;
using System.Collections.Generic;

namespace E09.SimpleTextEditor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOperations = int.Parse(Console.ReadLine());
            Stack<string> text = new Stack<string>();
            text.Push(string.Empty);

            for (int i = 0; i < numberOperations; i++)
            {
                string[] commandArgs = Console.ReadLine().Split();
                switch (commandArgs[0])
                {
                    case "1":
                        text.Push(text.Peek() + commandArgs[1]);
                        break;

                    case "2":
                        int delete = int.Parse(commandArgs[1]);
                       
                        string newState = text.Peek().Remove(text.Peek().Length - delete);
                        text.Push(newState);
                        break;

                    case "3":
                        int index = int.Parse(commandArgs[1]);
                        Console.WriteLine(text.Peek()[index-1]);
                        break;

                    case "4":
                        text.Pop();
                        break;

                }
            }
        }
    }
}

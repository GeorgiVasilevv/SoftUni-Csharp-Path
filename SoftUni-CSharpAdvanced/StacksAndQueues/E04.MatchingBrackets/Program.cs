﻿using System;
using System.Collections.Generic;

namespace E04.MatchingBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            
            Stack<int> indexes = new Stack<int>();

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    indexes.Push(i);
                }
                else if (expression[i] == ')')
                {
                    int startIndex = indexes.Pop();

                    Console.WriteLine(expression.Substring(startIndex,i-startIndex + 1));
                }
            }
        }
    }
}

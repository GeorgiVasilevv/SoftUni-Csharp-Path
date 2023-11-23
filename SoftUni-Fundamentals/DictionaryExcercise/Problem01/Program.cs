using System;
using System.Collections.Generic;

namespace Problem01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char,int> dic = new Dictionary<char,int>();
            string str = Console.ReadLine();

            for (int i = 0; i < str.Length; i++)
            {
                    char currChar = str[i];
                if (currChar !=' ')
                {
                    if (dic.ContainsKey(currChar))
                    {
                        dic[currChar]++;
                    }
                    else
                    {
                        dic.Add(currChar, 1);
                    }
                }
            }
            foreach (var item in dic)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}

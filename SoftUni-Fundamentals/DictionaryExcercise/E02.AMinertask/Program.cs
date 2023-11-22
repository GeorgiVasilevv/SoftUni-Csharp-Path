using System;
using System.Collections.Generic;

namespace E02.AMinertask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            string cmd = Console.ReadLine();
            while (cmd != "stop")
            {
                string ore = cmd;
                int count =int.Parse( Console.ReadLine());

                if (dic.ContainsKey(ore))
                {
                    dic[ore] += count;
                }
                else
                {
                    dic.Add(ore, count);
                }
                cmd = Console.ReadLine();
            }
            foreach (var item in dic)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace E04.ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string cmd = Console.ReadLine();
            while (cmd != "End")
            {
                string[] commands = cmd.Split().ToArray();
                string operation = commands[0];
                if (operation == "Add")
                {
                    int number = int.Parse(commands[1]);
                    array.Add(number);
                }
                else if (operation == "Insert")
                {
                    int number = int.Parse(commands[1]);
                    int index = int.Parse(commands[2]);
                    if (index<0 || index>array.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                    array.Insert(index, number);

                    }

                }
                else if (operation == "Remove")
                {

                    int index = int.Parse(commands[1]);
                    if (index < 0 || index > array.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                    array.RemoveAt(index);

                    }
                }
                else if (operation == "Shift")
                {
                    string secondOperation = commands[1];
                    int count = int.Parse(commands[2]);
                    array= ShiftList(array,secondOperation,count);
                }
                cmd = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", array));
        }
        public static List<int> ShiftList(List<int> array, string operation, int count)
        {
            int timesToShift = count % array.Count;
            if (operation == "left")
            {
                for (int i = 0; i < timesToShift;i++)
                {
                    int currentNum = array.First();
                    array.Remove(currentNum);
                    array.Add(currentNum);
                }
            }
            else if (operation == "right")
            {
                for (int i = timesToShift; i > 0; i--)
                {
                    int currentNum = array.Last();
                    array.RemoveAt(array.Count - 1);
                    array.Insert(0, currentNum);
                }
            }
            return array;
        }
    }
}

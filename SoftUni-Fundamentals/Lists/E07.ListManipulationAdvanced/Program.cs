using System;
using System.Collections.Generic;
using System.Linq;

namespace E07.ListManipulationAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();
            bool isChanged = false;
            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] line = command.Split(" ");
                string action = line[0];

                if (action == "Add")
                {
                    int itemToAdd = int.Parse(line[1]);
                    isChanged = true;
                    numbers.Add(itemToAdd);
                }

                else if (action == "Remove")
                {
                    int itemToRemove = int.Parse(line[1]);
                    isChanged = true;
                    numbers.Remove(itemToRemove);
                }

                else if (action == "RemoveAt")
                {
                    int indexToRemove = int.Parse(line[1]);
                    isChanged = true;
                    numbers.RemoveAt(indexToRemove);
                }

                else if (action == "Insert")
                {
                    int numToInsert = int.Parse(line[1]);
                    int indexToInsert = int.Parse(line[2]);

                    numbers.Insert(indexToInsert, numToInsert);
                    isChanged = true;

                }
                if (action == "Contains")
                {
                    numbers.Contains(int.Parse(line[1]));
                    if (numbers.Contains(int.Parse(line[1])))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }

                else if (action == "PrintEven")
                {
                    List<int> evenNums = numbers.FindAll(x => x % 2 == 0);
                    Console.WriteLine(string.Join(" ", evenNums));
                }

                else if (action == "PrintOdd")
                {
                    List<int> oddNums = numbers.FindAll(x => x % 2 != 0);
                    Console.WriteLine(string.Join(" ", oddNums));
                }

                else if (action == "GetSum")
                {
                    Console.WriteLine(numbers.Sum()); 


                }

                else if (action == "Filter")
                {
                    string condition = line[1];
                    int number = int.Parse(line[2]);
                    filter(numbers,condition,number);

                }

                command = Console.ReadLine();

            }
            if (isChanged==false)
            {
                return;
            }
            else
            {
                Console.WriteLine(String.Join(" ", numbers));
            }
        }
        public static void filter(List<int> numbers ,string condition,int number )
        {
            List<int> filteredNums = new List<int>();

            if (condition=="<")
            {
                filteredNums=(numbers.FindAll(x => x<number));
            }
            else if (condition==">")
            {
                filteredNums = (numbers.FindAll(x => x > number));
            }
            else if (condition=="<=")
            {
                filteredNums = (numbers.FindAll(x => x <= number));
            }
            else if (condition==">=")
            {
                filteredNums = (numbers.FindAll(x => x >= number));
            }
            Console.WriteLine(string.Join(" ", filteredNums));

        }
    }
}

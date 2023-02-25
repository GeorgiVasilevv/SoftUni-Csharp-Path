using System;
using System.Collections.Generic;
using System.Linq;

namespace E03.ItemBreak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> priceRatings = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            int entryPoint = int.Parse(Console.ReadLine());
            if (entryPoint < 2 || entryPoint > priceRatings.Count - 2)
            {
                entryPoint = int.Parse(Console.ReadLine());
            }
            string typeOfItems = Console.ReadLine();

            int leftIndex = entryPoint - 1;
            int rightIndex = entryPoint + 1;
            string leftOrRight;
            if (typeOfItems == "cheap")
            {

                if (priceRatings[leftIndex] == priceRatings[entryPoint])
                {
                    leftOrRight = "Left";
                    Console.WriteLine(leftOrRight + " - " + priceRatings[leftIndex]);
                }
                if (priceRatings[leftIndex] > priceRatings[rightIndex])
                {
                    leftOrRight = "Left";
                    Console.WriteLine(leftOrRight + " - " + priceRatings[leftIndex]);
                }
                if (priceRatings[leftIndex] < priceRatings[rightIndex])
                {
                    leftOrRight = "Right";
                    Console.WriteLine(leftOrRight + " - " + priceRatings[rightIndex]);
                }
            }
            else if (typeOfItems == "expensive")
            {
                if (priceRatings[leftIndex] == priceRatings[rightIndex])
                {
                    leftOrRight = "Left";
                    Console.WriteLine(leftOrRight + " - " + priceRatings[leftIndex]);
                }
                if (priceRatings[leftIndex] >= priceRatings[rightIndex])
                {
                    leftOrRight = "Left";
                    Console.WriteLine(leftOrRight + " - " + priceRatings[leftIndex]);
                }
                if (priceRatings[leftIndex] <= priceRatings[rightIndex])
                {
                    leftOrRight = "Right";
                    Console.WriteLine(leftOrRight + " - " + priceRatings[rightIndex]);
                }
            }
        }
    }
}

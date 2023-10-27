using System;
using System.Linq;

namespace E010.LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] indexWhereBugsCanBeFound = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int[] ladyBugField = new int[size];

            for (int i = 0; i < size; i++)
            {
                if (indexWhereBugsCanBeFound.Contains(i))
                {
                    ladyBugField[i] = 1;
                }
            }
            string changePosition;
            while ((changePosition = Console.ReadLine())!="end")
            {
                string[] command = changePosition
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                int ladyBugIndex = int.Parse(command[0]);
                string direction = command[1];
                int flyLength = int.Parse(command[2]);

                if (ladyBugIndex<0 || ladyBugIndex>=ladyBugField.Length)
                {
                    continue;
                }
                if (ladyBugField[ladyBugIndex] ==0)
                {
                    continue;
                }
                ladyBugField[ladyBugIndex] = 0;
                int nextIndex = ladyBugIndex;

                while (true)
                {
                    if (direction=="right")
                    {
                        nextIndex += flyLength;
                    }
                    if (direction == "left")
                    {
                        nextIndex -= flyLength;
                    }
                    if (nextIndex<0 || nextIndex>= ladyBugField.Length)
                    {
                        break;
                    }
                    if (ladyBugField[nextIndex]==0)
                    {
                        
                        break;
                    }
                    
                   
                }
                if (nextIndex >= 0 && nextIndex <ladyBugField.Length)
                {
                    ladyBugField[nextIndex] = 1;
                }
            }
            Console.WriteLine(string.Join(" ",ladyBugField));
        }
    }
}

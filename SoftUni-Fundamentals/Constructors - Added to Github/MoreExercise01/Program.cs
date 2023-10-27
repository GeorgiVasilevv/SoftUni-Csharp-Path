using System;
using System.Linq;

namespace MoreExercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrayOfSums = new int[n];
            string vowels = "EeUuIiOoAa";
            int vowelsSum = 0;
            int consonantSum = 0;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();


                for (int j = 0; j < name.Length; j++)
                {
                    char currentChar = name[j];
                    if (vowels.Contains(currentChar))
                    {
                        vowelsSum += (int)currentChar * name.Length;
                    }
                    else
                    {
                        consonantSum += (int)currentChar / name.Length;
                    }
                }
                sum = vowelsSum + consonantSum;
                arrayOfSums[i] = sum;
                vowelsSum = 0;
                consonantSum = 0;
                sum = 0;
            }
            Array.Sort(arrayOfSums);
            for (int i = 0; i < arrayOfSums.Length; i++)
            {
                Console.WriteLine(arrayOfSums[i]);

            }



        }
    }
}

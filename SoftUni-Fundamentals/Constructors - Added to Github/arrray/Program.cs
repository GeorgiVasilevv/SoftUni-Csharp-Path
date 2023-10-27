using System;

namespace arrray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] =int.Parse( Console.ReadLine());
            }
            int secoundLargest = array[0];
            int firstLargest = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]>firstLargest)
                {
                    secoundLargest = firstLargest;
                    firstLargest = array[i];
                }
                else if (array[i]>secoundLargest && array[i]<firstLargest)
                {
                    secoundLargest = array[i];
                }
            }
            Console.WriteLine(firstLargest);
            Console.WriteLine(secoundLargest);
        }
    }
}

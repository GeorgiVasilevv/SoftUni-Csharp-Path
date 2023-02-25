using System;
using System.Linq;
using System.Text;

namespace E02.RepeatStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder stringBuilder = new StringBuilder();
            string[] words = Console.ReadLine().Split(' ');
            foreach (var word in words)
            {
                int charCount = word.Length;
                for (int i = 0; i < charCount; i++)
                {
                    stringBuilder.Append(word);
                }
            }
            Console.WriteLine(stringBuilder);
        }
    }
}

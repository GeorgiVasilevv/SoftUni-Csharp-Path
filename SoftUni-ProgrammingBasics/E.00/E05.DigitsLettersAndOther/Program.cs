using System;

namespace E05.DigitsLettersAndOther
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string digits =string.Empty;
            string letters = string.Empty;
            string otherChars = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                char currChar = input[i];
                if (char.IsDigit(currChar))
                {
                    digits += currChar;
                }
                else if (char.IsLetter(currChar))
                {
                    letters +=currChar;
                }
                else
                {
                    otherChars +=currChar;
                }

            }
            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(otherChars);
        }
    }
}

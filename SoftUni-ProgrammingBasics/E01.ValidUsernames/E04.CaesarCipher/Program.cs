using System;

namespace E04.CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string unencrypted = Console.ReadLine();
            string encrypted = string.Empty;
            foreach (char character in unencrypted)
            {
                int charValue = character;
                charValue += 3;
                encrypted += (char)charValue;
            }
            Console.WriteLine(encrypted);
        }
    }
}

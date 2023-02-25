using System;
using System.Text;

namespace E07.StringExplosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            StringBuilder stringBuilder = new StringBuilder();
            int bombPower = 0;
            for (int i = 0; i < line.Length; i++)
            {
                char currChar = line[i];
                if (currChar == '>')
                {
                    int currBombPower = line[i+1]-48;
                    stringBuilder.Append(currChar);
                    bombPower+=currBombPower;
                }
                else
                {
                    if (bombPower>0)
                    {
                        bombPower--;
                    }
                    else
                    {
                        stringBuilder.Append(currChar);
                    }
                }
            }
            Console.WriteLine(stringBuilder.ToString());
        }
    }
}

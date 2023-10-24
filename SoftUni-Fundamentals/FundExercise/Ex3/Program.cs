using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            int counter = 0;
            string reversed = string.Empty;

            for (int i = username.Length-1; i >=0 ; i--)
            {
                reversed += username[i];
            }
            for (int count = 1; count <= 4; count++)
            {
                string password = Console.ReadLine();
                if (password==reversed)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else
                {
                    if (count==4)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect password. Try again.");
                    }
                }
            }
            
            
            
        }
    }
}

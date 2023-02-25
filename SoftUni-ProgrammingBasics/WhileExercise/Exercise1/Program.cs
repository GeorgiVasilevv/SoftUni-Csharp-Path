using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            string favouriteBook = Console.ReadLine();
            int counter = 0;
            bool isTrue = false;
            string bookSearch = Console.ReadLine();
            while (bookSearch != "No More Books")
            {
                if (bookSearch == favouriteBook)
                {
                    isTrue = true;
                    break;
                }
                counter++;
                bookSearch = Console.ReadLine();

            }
            if (isTrue)
            {
                Console.WriteLine($"You checked {counter} books and found it.");

            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
            }
        }
    }
}

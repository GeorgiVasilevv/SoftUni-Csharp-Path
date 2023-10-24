using System;

namespace FundExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var age =int.Parse( Console.ReadLine());
            if (age<=2 && age>=0)
            {
                Console.WriteLine("baby");
            }
            else if (age>2 && age<=13)
            {
                Console.WriteLine("child");
            }
            else if (age>13 && age<=19)
            {
                Console.WriteLine("teenager");
            }
            else if (age>19 && age<=65)
            {
                Console.WriteLine("adult");
            }
            else if (age>=66)
            {
                Console.WriteLine("elder");
            }
        }
    }
}

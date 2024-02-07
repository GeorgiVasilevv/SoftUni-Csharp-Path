using System;
using System.Collections.Generic;

namespace E08.SoftuniParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vipGuests = new HashSet<string>();
            HashSet<string> regularGuests = new HashSet<string>();

            string command = Console.ReadLine();
            while (command != "PARTY")
            {
                if (char.IsDigit(command[0]))
                {
                    vipGuests.Add(command);
                }
                else
                {
                    regularGuests.Add(command);
                }
                command = Console.ReadLine();
            }

            command = Console.ReadLine();
            while (command != "END")
            {
                vipGuests.Remove(command);
                regularGuests.Remove(command);
                command = Console.ReadLine();
            }
            Console.WriteLine(vipGuests.Count + regularGuests.Count);
            if (vipGuests.Count > 0)
                Console.WriteLine(String.Join("\n", vipGuests));

            if (regularGuests.Count > 0)
                Console.WriteLine(String.Join("\n", regularGuests));
        }
    }
}

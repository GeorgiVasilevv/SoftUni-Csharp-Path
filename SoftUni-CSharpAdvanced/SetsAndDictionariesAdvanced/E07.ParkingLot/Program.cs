using System;
using System.Collections.Generic;

namespace E07.ParkingLot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] tokens = command.Split(", ");
                if (tokens[0] == "IN")
                {
                    set.Add(tokens[1]);
                }
                else if (tokens[0] == "OUT")
                {
                    set.Remove(tokens[1]);
                }
                command = Console.ReadLine();
            }

            if (set.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
                return;
            }
            foreach (var plateNum in set)
            {
                Console.WriteLine(plateNum);
            }
        }
    }
}

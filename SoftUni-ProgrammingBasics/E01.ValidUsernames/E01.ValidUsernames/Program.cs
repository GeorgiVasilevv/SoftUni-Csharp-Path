using System;
using System.Collections.Generic;

namespace E01.ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries);
            List<string> validUsernames = new List<string>();
            foreach (var user in usernames)
            {
                if ((user.Length >=3  &&  user.Length <=16))
                {
                    if (ValidUserNames(user))
                    {
                        validUsernames.Add(user);
                    }
                }
            }
            Console.WriteLine(string.Join("\n" , validUsernames));
        }
        static bool ValidUserNames(string user)
        {
            foreach (var symbol in user)
            {
                if (char.IsLetterOrDigit(symbol) || symbol=='-' || symbol=='_')
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}

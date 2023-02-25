using System;
using System.Collections.Generic;
using System.Linq;

namespace E03.ChatLogger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> chats = new List<string>();
            string cmd = Console.ReadLine();
            while (cmd!= "end")
            {
                string[] split = cmd.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string command = split[0];

                if (command== "Chat")
                {
                    string message = split[1];
                    chats.Add(message);
                }
                else if (command == "Delete")
                {
                    string message = split[1];
                    if (!chats.Contains(message))
                    {
                        cmd = Console.ReadLine();
                        continue;
                    }
                    chats.Remove(message);//
                }
                else if (command == "Edit")
                {
                    string message = split[1];
                    string editedVersion = split[2];
                    int index = chats.IndexOf(message);
                    chats.Remove(message);
                    chats.Insert(index, editedVersion);
                    
                }
                else if (command == "Pin")
                {
                    string message = split[1];
                    if (!chats.Contains(message))
                    {
                        cmd = Console.ReadLine();
                        continue;
                    }
                    chats.Remove(message);
                    chats.Add(message);
                }
                else if (command == "Spam")
                {
                    for (int i = 1; i < split.Length; i++)
                    {
                        chats.Add(split[i]);
                    }



                }
                cmd = Console.ReadLine();
            }
            for (int i = 0; i < chats.Count; i++)
            {
                Console.WriteLine(chats[i]);
            }
        }
    }
}

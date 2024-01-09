using System;
using System.Collections;
using System.Collections.Generic;

namespace E06.SongsQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> songs = new Queue<string>(Console.ReadLine().Split(", "));


            while (songs.Count >0)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "Play")
                {
                    songs.Dequeue();
                }
                else if (command[0] == "Add")
                {
                    string songName = string.Join(" ", command).Substring(4);
                    if (songs.Contains(songName))
                    {
                        Console.WriteLine($"{songName} is already contained!");
                        continue;
                    }
                    songs.Enqueue(songName);
                }
                else if (command[0] == "Show")
                {
                    Console.WriteLine(String.Join(", ",songs));
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}

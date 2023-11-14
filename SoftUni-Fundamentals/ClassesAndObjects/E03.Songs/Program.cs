using System;
using System.Collections.Generic;

namespace E03.Songs
{
    internal class Program
    {

        class Song
        {
            public Song(string typeList, string name, string time)
            {
                this.TypeList = typeList;
                this.Name = name;
                this.Time = time;
            }
            public string TypeList { get; set; }
            public string Name { get; set; }
            public string Time { get; set; }



        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split("_", StringSplitOptions.RemoveEmptyEntries);


                string type = tokens[0];
                string name = tokens[1];
                string time = tokens[2];

                Song song = new Song(type, name, time);
                songs.Add(song);
            }

            string cmd = Console.ReadLine();
            if (cmd == "all")
            {
                foreach (var song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                List<Song> filteredSongs = songs.FindAll(x => x.TypeList == cmd);
                foreach (Song song in filteredSongs)
                {
                    Console.WriteLine(song.Name);
                }
            }

        }
    }
}

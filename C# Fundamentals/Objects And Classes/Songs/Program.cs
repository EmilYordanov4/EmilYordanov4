using System;
using System.Collections.Generic;
using System.Linq;

namespace Songs
{
    
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>(); 

            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] songInfo = Console.ReadLine().Split("_").ToArray();

                Song song = new Song();

                song.TypeList = songInfo[0];
                song.Name = songInfo[1];
                song.Time = songInfo[2];

                songs.Add(song);
            }

            string neededType = Console.ReadLine();

            if (neededType == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in songs.Where(x => x.TypeList == neededType))
                {
                    Console.WriteLine(song.Name);
                }
            }
        }
    }
}

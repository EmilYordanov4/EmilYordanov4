using System;
using System.Collections.Generic;
using System.Linq;

namespace SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstSongs = Console.ReadLine().Split(", ");
            Queue<string> songs = new Queue<string>(firstSongs);

            while (songs.Count != 0)
            {
                string[] cmd = Console.ReadLine().Split(" ", 2);

                string typeOfCmd = cmd[0];

                if (typeOfCmd == "Play")
                {
                    if (songs.Any())
                    {
                        songs.Dequeue();
                    }
                }
                else if (typeOfCmd == "Add")
                {
                    string song = cmd[1];
                    if (songs.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        songs.Enqueue(song);
                    }
                }
                else if (typeOfCmd == "Show")
                {
                    if (songs.Any())
                    {
                        Console.WriteLine(string.Join(", ", songs));
                    }
                }
            }

            Console.WriteLine($"No more songs!");
        }
    }
}

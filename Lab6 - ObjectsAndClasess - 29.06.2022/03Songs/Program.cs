using System;
using System.Collections.Generic;

namespace _03Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            //03. Songs
            //Define a class called Song that will hold the following information about some songs:
            //    • Type List
            //    • Name
            //    • Time
            //Input / Constraints
            //    • On the first line, you will receive the number of songs -N.
            //    • On the next N lines, you will be receiving data in the following
            //    format: "{typeList}_{name}_{time}".
            //    • On the last line, you will receive Type List or "all".
            //Output
            //If you receive Type List as an input on the last line, print out
            //only the names of the songs, which are from that Type List.If you
            //receive the "all" command, print out the names of all the songs.


            int numberOfSongs = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] songProparties = Console.ReadLine().Split('_');

                Song song = new Song(songProparties[0], songProparties[1], songProparties[2]);

                songs.Add(song);
            }

            string lastInput = Console.ReadLine();

            if (lastInput == "all")
            {
                foreach (var song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (var song in songs)
                {
                    if (lastInput == song.TypeList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }           
        }
    }

    class Song
    {
        public Song(string typeList,string name, string time)
        {
            this.TypeList = typeList;
            this.Name = name;
            this.Time = time;
        }

        public string TypeList { get; set; }

        public string Name { get; set; }

        public string Time { get; set; }

    }
}

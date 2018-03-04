using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        var songs = new List<Song>();

        int numberOfSongs = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfSongs; i++)
        {
            try
            {
                var input = Console.ReadLine().ToLower().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var time = input[2].Split(':').ToArray();
                int firstNum;
                int secondNum;

                if (int.TryParse(time[0], out firstNum) && int.TryParse(time[1], out secondNum))
                {
                    if (firstNum * 60 + secondNum > 0 || firstNum * 60 + secondNum < 14 * 60 + 59)
                    {
                        songs.Add(new Song(input[0], input[1], firstNum, secondNum));
                        Console.WriteLine("Song added.");
                    }

                }
                else
                {
                    throw new InvalidSongLengthException();
                }

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }

        var totalDuration = songs.Sum(x => x.Minutes * 60 + x.Seconds);

        var totalHours = totalDuration / 60 / 60;
        var totalMinutes = (totalDuration / 60) - (totalHours * 60);
        long totalSeconds = totalDuration % 60;


        Console.WriteLine($"Songs added: {songs.Count}");
        Console.WriteLine($"Playlist length: {totalHours}h {totalMinutes}m {totalSeconds}s");
    }
}

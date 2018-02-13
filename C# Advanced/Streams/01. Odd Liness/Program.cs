using System;
using System.Collections.Generic;
using System.IO;

namespace Streams
{
    class Streams
    {
        static void Main(string[] args)
        {
            using (var stream = new StreamReader("text.txt"))
            {
                string lineText;
                int counter = 0;

                while ((lineText = stream.ReadLine()) != null)
                {
                    if (counter % 2 != 0)
                    {
                        Console.WriteLine(lineText);
                    }
                    counter++;
                }
            }
        }
    }
}

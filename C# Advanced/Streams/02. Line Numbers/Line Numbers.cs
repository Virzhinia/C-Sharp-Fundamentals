using System;
using System.IO;

namespace _02._Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var streamReader = new StreamReader("text.txt"))
            {
                using (var streamWrite = new StreamWriter("line_text.txt"))
                {
                    var lineNum = 1;
                    string textLine;
                    while ((textLine = streamReader.ReadLine()) != null)
                    {
                        streamWrite.WriteLine($"Line {lineNum}: {textLine}");
                        lineNum++;
                    }
                }
            }
        }
    }
}

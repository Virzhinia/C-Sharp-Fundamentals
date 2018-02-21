using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var streamReaderWords = new StreamReader("words.txt"))
            {
                using (var streamReaderText = new StreamReader("text.txt"))
                {
                    using (var streamWriteResult = new StreamWriter("result.txt"))
                    {
                        Dictionary<string, int> wordsDict = new Dictionary<string, int>();
                        string wordsLine;

                        while ((wordsLine=streamReaderWords.ReadLine()) != null)
                        {
                            wordsLine = wordsLine.ToLower();
                            wordsDict.Add(wordsLine,0);
                        }

                        string textLine;
                        while((textLine=streamReaderText.ReadLine()) !=null)
                        {
                            textLine=textLine.ToLower();
                            string[] textArr = textLine
                                .Split(new char[] { '-', ',', ' ', '.', '!', '?' },StringSplitOptions.RemoveEmptyEntries);

                            foreach (var item in textArr)
                            {
                                if (wordsDict.ContainsKey(item))
                                {
                                    wordsDict[item]+=1;
                                }
                            }
                        }
                        
                        foreach (var item in wordsDict.OrderByDescending(c => c.Value))
                        {
                            streamWriteResult.WriteLine($"{item.Key} - {item.Value}");
                        }
                    }
                }
            }
        }
    }
}

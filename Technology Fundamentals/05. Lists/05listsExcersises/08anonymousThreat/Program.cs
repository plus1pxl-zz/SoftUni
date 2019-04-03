using System;
using System.Collections.Generic;
using System.Linq;

namespace _08anonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> collection = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            List<string> output = new List<string>();
            string input = Console.ReadLine();

            while (input != "3:1")
            {
                List<string> command = input
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

                if (command[0].ToLower() == "merge")
                {
                    string merged = "";
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);

                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    if (endIndex > collection.Count - 1)
                    {
                        endIndex = collection.Count - 1;
                    }

                    for (int i = startIndex; i <= endIndex ; i++)
                    {
                        merged += collection[startIndex];
                        collection.RemoveAt(startIndex);
                    }
                    collection.Insert(startIndex, merged);
                    //Console.WriteLine(string.Join(' ', collection));
                }
                else if (command[0].ToLower() == "divide")
                {
                    int indexToSplit = int.Parse(command[1]);
                    int chunks = int.Parse(command[2]);

                    List<string> split = SplitString(collection[indexToSplit], chunks);

                    collection.RemoveAt(indexToSplit);
                    for (int i = split.Count() - 1 ; i >= 0; i--)
                    {
                        collection.Insert(indexToSplit, split[i]);
                    }

                    //Console.WriteLine(string.Join(' ', collection));
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(' ', collection));
        }

        public static List<string> SplitString(string str, int chunks)
        {
            var l = new List<string>();
            if (string.IsNullOrEmpty(str))
                return l;
            if (str.Length < chunks)
            {
                l.Add(str);
                return l;
            }
            int chunkSize = str.Length / chunks;

            int stringLength = str.Length;
            for (int i = 0; i < stringLength; i += chunkSize)
            {
                if (i + chunkSize > stringLength)
                    chunkSize = stringLength - i;
                l.Add(str.Substring(i, chunkSize));
            }
            string residual = "";
            l.Where((f, i) => i > chunks - 1).ToList().ForEach(f => residual += f);
            l[chunks - 1] += residual;
            return l.Take(chunks).ToList();
        }
    }
}

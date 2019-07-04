using System;
using System.IO;

namespace _02_LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFilePath = "Files" + Path.DirectorySeparatorChar + "Input.txt";
            string outputFilePath = "Files" + Path.DirectorySeparatorChar + "Output.txt";

            using (var reader = new StreamReader(inputFilePath))
            {
                int counter = 1;
                string line = reader.ReadLine();

                using (var writer = new StreamWriter(outputFilePath))
                {
                    while (line != null)
                    {
                        //Console.WriteLine($"{counter}. {line}");
                        writer.WriteLine($"{counter}. {line}");
                        line = reader.ReadLine();
                        counter++;
                    }
                }
            }
        }
    }
}

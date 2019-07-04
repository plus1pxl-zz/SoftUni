using System;
using System.IO;

namespace _01_OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "Files" + Path.DirectorySeparatorChar + "Input.txt";
            using (var reader = new StreamReader(filePath))
            {
                int counter = 0;
                string line = reader.ReadLine();

                while (line != null)
                {

                    if (counter %2 != 0)
                    {
                        Console.WriteLine(line);
                    }
                    counter++;
                    line = reader.ReadLine();
                }
            }
        }
    }
}

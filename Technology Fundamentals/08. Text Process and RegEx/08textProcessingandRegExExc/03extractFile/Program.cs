using System;
using System.Linq;

namespace _03extractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();
            string[] pathSegments = path.Split("\\").ToArray();

            string file = pathSegments[pathSegments.Length - 1];
            string[] fileSegments = file.Split(".").ToArray();

            string fileExtension = fileSegments[fileSegments.Length - 1];
            string fileName = file.Remove(file.Length - (fileExtension.Length + 1));

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}

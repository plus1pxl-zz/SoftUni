﻿using System;
using System.IO;

namespace _05_SliceAFile
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var inputFile = new FileStream(@"files\sliceMe.txt", FileMode.Open))
            {
                long size = inputFile.Length;
                int partSize = (int)Math.Ceiling((double)size / 4);
                byte[] buffer = new byte[partSize];

                for (int i = 1; i <= 4; i++)
                {
                    using (var outputFile = new FileStream($"Files\\Part-{i}.txt", FileMode.Create))
                    {
                        int readedBytes = inputFile.Read(buffer, 0, partSize);
                        outputFile.Write(buffer, 0, readedBytes);
                    }
                }
            }
        }
    }
}

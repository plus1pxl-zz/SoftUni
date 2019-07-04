using System;
using System.IO;

namespace _04_MergeFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader1 = new StreamReader(@"Files\FileOne.txt"))
            {
                string line1 = reader1.ReadLine();
                using (var reader2 = new StreamReader(@"Files\FileTwo.txt"))
                {
                    string line2 = reader2.ReadLine();
                    using (var writer = new StreamWriter(@"Files\Output.txt"))
                    {
                        while (line1 != null && line2 != null)
                        {
                            writer.WriteLine(line1);
                            line1 = reader1.ReadLine();
                            writer.WriteLine(line2);
                            line2 = reader2.ReadLine();
                        }

                    }
                }

            }
        }
    }
}

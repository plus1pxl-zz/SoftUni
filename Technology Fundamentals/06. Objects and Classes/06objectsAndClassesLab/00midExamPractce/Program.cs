using System;
using System.Linq;

namespace _00midExamPractce
{
    class Program
    {
        static void Main(string[] args)
        {
            var kids = Console.ReadLine().Split('&').ToList();

            while (true)
            {
                var command = Console.ReadLine();
                // TODO: Bad
                // TODO: Good
                // TODO: Rename
                // TODO: Rearrange
                if (command == "Finished!")
                {
                    break;
                }

                var commandParts = command.Split(' ');

                if (commandParts[0].ToLower() == "bad")
                {
                    var kidName = commandParts[1];
                    if (!kids.Contains(kidName))
                    {
                        kids.Insert(0, kidName);
                    }

                }
                if (commandParts[0].ToLower() == "good")
                {
                    var kidName = commandParts[1];
                    if (kids.Contains(kidName))
                    {
                        kids.Remove(kidName);
                    }
                }

                if (commandParts[0].ToLower() == "rename")
                {
                    var kidName = commandParts[1];
                    var newKidName = commandParts[2];
                    if (kids.Contains(kidName))
                    {
                        var indexOfKidName = kids.IndexOf(kidName);
                        kids[indexOfKidName] = newKidName;
                    }

                }
                if (commandParts[0].ToLower() == "rearrange")
                {
                    var kidName = commandParts[1];
                    if (kids.Contains(kidName))
                    {
                        kids.Remove(kidName);
                        kids.Add(kidName);
                    }
                }



            }
            Console.WriteLine(String.Join(", ", kids));

        }
    }
}

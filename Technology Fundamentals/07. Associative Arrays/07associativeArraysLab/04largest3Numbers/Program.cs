using System;
using System.Linq;

namespace _04largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var top3 = Console.ReadLine().Split()
                .Select(int.Parse).OrderByDescending(x => x).Take(3);

            foreach (var number in top3)
            {
                Console.Write(number + " ");
            }
        }
    }
}

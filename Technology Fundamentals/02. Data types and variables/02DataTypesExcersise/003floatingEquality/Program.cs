using System;

namespace _003floatingEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            double eps = 0.000001;
            double difference = Math.Abs(n1 - n2);

            if (difference <= eps)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

        }
    }
}

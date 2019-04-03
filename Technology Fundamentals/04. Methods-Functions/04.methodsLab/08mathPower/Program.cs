using System;

namespace _08mathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            int pow = int.Parse(Console.ReadLine());
            double result = RaiseToPower(num, pow);
            Console.WriteLine(result);
        }

        static double RaiseToPower(double num, int pow)
        {
            double result = num;
            for (int i = 1; i < pow; i++)
            {
                result *= num;
            }
            return result;
        }


    }
}

using System;

namespace _03calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string action = Console.ReadLine();
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            switch (action)
            {
                case "add":
                    SumUp(n1, n2);
                    break;
                case "multiply":
                    Multiplication(n1, n2);
                    break;
                case "substract":
                    Substraction(n1, n2);
                    break;
                case "divide":
                    Division(n1, n2);
                    break;


                default:
                    break;
            }
        }

        static void SumUp(int n1, int n2)
        {
            Console.WriteLine(n1 + n2);
        }

        static void Multiplication(int n1, int n2)
        {
            Console.WriteLine(n1 * n2);
        }

        static void Substraction(int n1, int n2)
        {
            Console.WriteLine(n1 - n2);
        }

        static void Division(int n1, int n2)
        {
            Console.WriteLine(n1 / n2);
        }




    }
}

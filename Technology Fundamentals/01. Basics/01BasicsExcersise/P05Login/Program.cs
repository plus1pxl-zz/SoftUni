using System;

namespace P05Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string user = Console.ReadLine();
            string pass = "";
            int counter = 0;
            string login = "";

            for (int i = user.Length - 1; i >= 0; i--)
            {
                pass += user[i];
            }

            while (login != pass)
            {
                login = Console.ReadLine();
                counter++;
                if (counter == 4)
                {
                    Console.WriteLine($"User {user} blocked!");
                    break;
                }
                if (login != pass)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
            }
            if (login == pass)
            {
                Console.WriteLine($"User {user} logged in.");
            }
        }
    }
}

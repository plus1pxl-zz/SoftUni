using System;

namespace _03gamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double balance = money;
            string input = Console.ReadLine();

            while (input !="Game Time" || balance !=0)
            {
                if (input == "OutFall 4")
                {
                    if (balance >= 39.99)
                    {
                        Console.WriteLine($"Bought {input}");
                        balance -= 39.99;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    
                }
                else if (input == "CS: OG")
                {
                    if (balance >= 15.99)
                    {
                        Console.WriteLine($"Bought {input}");
                        balance -= 15.99;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }

                }
                else if (input == "Zplinter Zell")
                {
                    if (balance >= 19.99)
                    {
                        Console.WriteLine($"Bought {input}");
                        balance -= 19.99;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }

                }
                else if (input == "Honored 2")
                {
                    if (balance >= 59.99)
                    {
                        Console.WriteLine($"Bought {input}");
                        balance -= 59.99;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }

                }
                else if (input == "RoverWatch")
                {
                    if (balance >= 29.99)
                    {
                        Console.WriteLine($"Bought {input}");
                        balance -= 29.99;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }

                }
                else if (input == "RoverWatch Origins Edition")
                {
                    if (balance >= 39.99)
                    {
                        Console.WriteLine($"Bought {input}");
                        balance -= 39.99;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }

                }
                else if (input == "Game Time")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Not Found");
                }

                input = Console.ReadLine();

            }
            if (balance == 0)
            {
                Console.WriteLine("Out of money!");
            }
            else if (input == "Game Time")
            {
                Console.WriteLine($"Total spent: ${money-balance:F2}. Remaining: ${balance:F2}");
            }


        }
    }
}

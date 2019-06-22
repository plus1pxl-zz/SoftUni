using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _11_KeyRevolver
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int gunBarrelSize = int.Parse(Console.ReadLine());
            int bulletsInBarrel = gunBarrelSize;
            var bullets = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var locks = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int valueOfIntelligence = int.Parse(Console.ReadLine());
            Stack<int> stackBullets = new Stack<int>(bullets);
            Queue<int> queueLocks = new Queue<int>(locks);

            while (stackBullets.Count !=0 && queueLocks.Count !=0)
            {
                if (bulletsInBarrel > 0  && stackBullets.Count >= 0)
                {
                    bulletsInBarrel--;
                    if (stackBullets.Pop() <= queueLocks.Peek())
                    {
                        Console.WriteLine("Bang!");
                        queueLocks.Dequeue();
                    }
                    else
                    {
                        //stackBullets.Pop();
                        Console.WriteLine("Ping!");
                    }
                }
                else if (bulletsInBarrel == 0 && stackBullets.Count >= 1)
                {
                    Console.WriteLine("Reloading!");
                    if (stackBullets.Count > gunBarrelSize)
                    {
                        bulletsInBarrel = gunBarrelSize;
                    }
                    else
                    {
                        bulletsInBarrel = stackBullets.Count;
                    }
                    
                }
            }
            if (bulletsInBarrel == 0 && stackBullets.Count >= 1)
            {
                Console.WriteLine("Reloading!");
                if (stackBullets.Count > gunBarrelSize)
                {
                    bulletsInBarrel = gunBarrelSize;
                }
                else
                {
                    bulletsInBarrel = stackBullets.Count;
                }

            }
            if (queueLocks.Count == 0)
            {
                int bulletsLeft = stackBullets.Count;
                int moneyEarned = valueOfIntelligence - ((bullets.Length - stackBullets.Count) * bulletPrice);
                Console.WriteLine($"{bulletsLeft} bullets left. Earned ${moneyEarned}");
            }
            else
            {
                int locksLeft = queueLocks.Count;
                Console.WriteLine($"Couldn't get through. Locks left: {locksLeft}");
            }

        }
    }
}

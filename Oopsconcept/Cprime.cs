using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class Cprime
    {
        public static bool isPrime(int num)
        {
            
            for(int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    
                    return false;
                    
                }
            }
            return true;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());

            if (isPrime(num))
            {
                Console.WriteLine("prime");
            }
            else
            {
                Console.WriteLine("not");
            }
            for(int i = 1; i < 500; i++)
            {
                if (isPrime(i))
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}

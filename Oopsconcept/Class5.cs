using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class Class5
    {
        public static bool isprime(int num)
        {
            int c = 0;
            for(int i = 2; i < num / 2; i++)
            {
                if (num % i == 0)
                {
                    c++;
                    break;
                }
            }
            if (c == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter ");
            int num = int.Parse(Console.ReadLine());

            
            if (isprime(num))
            {
                Console.WriteLine("prime");
            }
            else
            {
                Console.WriteLine("not");
            }

        }
    }
}

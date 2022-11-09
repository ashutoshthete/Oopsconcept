using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class Class19
    {
        static bool isprime(int n)
        {
            if (n <= 1)
                return false;
            for(int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("enter num");
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            int r;
            while (num > 0)
            {
                r = num % 10;
                if (isprime(r))
                {
                    Console.WriteLine(r);
                    count++;
                }

                num = num / 10;
            }
            
        }
    }
}

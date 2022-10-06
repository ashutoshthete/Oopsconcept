using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class CoPrime
    {
        static int CD(int a,int b)
        {
            if (a == 0 || b == 0)
            {
                return 0;
            }
            if (a == b)
            {
                return a;
            }
            if (a > b)
            {
                return CD(a - b, b);
            }
            return CD(a, b - a);
        }
        static void coprime(int a,int b)
        {
            if (CD(a, b) == 1)
            {
                Console.WriteLine("Co-Prime");
            }
            else
            {
                Console.WriteLine("Not Co-Prime");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second number");
            int b = int.Parse(Console.ReadLine());
            coprime(a, b);
        }
    }
    class Cooprime
    {
        static bool iscoprime(int a,int b)
        {
            int gcd = 1;
            for(int i = 1; i <= a && i <= b; i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    gcd = i;
                }
            }
            if (gcd == 1) 
                return true;
            else
                return false;
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first number :");
            int n1 = int.Parse(Console.ReadLine());
            int c = 0;
            for(int i = 1; i < n1; i++)
            {
                if (iscoprime(i, n1))
                {
                    c++;
                }
            }
            Console.WriteLine("Count : "+c);
        }
    }
}

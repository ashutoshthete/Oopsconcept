using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class Prime
    {
        public bool checkprime(int num)
        {
            for(int i = 2; i <= num / 2; i++)
            {
                if (num % i==0)
                {
                    return false;
                }
            }
            return true;
        }
        public static void Main(string[] args)
        {
             Prime p=new Prime();
            Console.WriteLine("Enter the number ");
            int num = int.Parse(Console.ReadLine());
            bool result = p.checkprime(num);
            if (result)
            {
                Console.WriteLine("prime");
            }
            else
            {
                Console.WriteLine("not prime");
            }
        }
    }
    class prime2
    {
       
        public static bool checkprime(int num)
        {
            
            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                    return false;
            }

            return true;

        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("enter");
            int num = int.Parse(Console.ReadLine());
            if (checkprime(num))
            {
                Console.WriteLine("prime");
            }
            else
            {
                Console.WriteLine("not prime");
            }
        }
    }
}

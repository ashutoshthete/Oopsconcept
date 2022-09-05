using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class TwinPrime
    {
        public static bool checkprime(int num)
        {
            int i = 0;
            if (num > 1)
            {
                for (i = 2; i < num; i++)
                {
                    if (num%i == 0)
                    {
                        return false;

                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }
       
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 0, diff = 0;
            bool isnum1 = false, isnum2 = false;
            Console.WriteLine("enter first");
             num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter first");
            num2 = int.Parse(Console.ReadLine());
            isnum1 = checkprime(num1);
            isnum2 = checkprime(num2);

            diff = Math.Abs(num1 - num2);


            if (diff == 2)
            {
                if (isnum1 == false || isnum2 == false)
                {
                    Console.WriteLine("Not twin prime");
                }
                else
                {
                    Console.WriteLine("Twin Prime");
                }
            }
            else
            {
                Console.WriteLine("are not tim prime");
            }
            
        }
    }
}

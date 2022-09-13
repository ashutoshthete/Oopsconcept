using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class Armstrongnum
    {
        
        public static int CheckArmstrong(int num)
        {
           
            int sum = 0;
            while (num > 0)
            {
                int r = num % 10;
                sum = sum + (r * r * r);
                num = num / 10;
            }
            return sum;
        }
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the num to Check");
            int num = int.Parse(Console.ReadLine());
            int copy = num;
            
            CheckArmstrong(num);
            if (CheckArmstrong(num) == copy)
            {
                Console.WriteLine("Armstrong");
            }
            else
            {
                Console.WriteLine("not ");
            }
        }
    }
}

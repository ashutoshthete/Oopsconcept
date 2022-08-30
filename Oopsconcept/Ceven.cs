using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class Ceven
    {
        public static bool isEven(int num)
        {
            if (num % 2 == 0)
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
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());

           if(isEven(num))
                Console.WriteLine("Even number ");
           else
                Console.WriteLine("odd");
        }
    }
}

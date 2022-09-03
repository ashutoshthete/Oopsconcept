using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 1;
            int num3;
            
            Console.WriteLine("Enter The Number till you want to print : ");
            int num = int.Parse(Console.ReadLine());
            Console.Write(num1+" "+num2+" ");
            for(int i = 2; i < num; ++i)
            {
                num3 = num1 + num2;
                Console.Write(num3+" ");
                num1 = num2;
                num2 = num3;
            }
        }
    }
}

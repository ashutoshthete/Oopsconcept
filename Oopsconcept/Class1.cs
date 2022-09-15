using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class Class1
    {
      
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the base :");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the index :");
            int index = int.Parse(Console.ReadLine());

            int power = 1;
            for (int i = 1; i <= index; i++)
            {
                power = power * index;
            }
            Console.WriteLine(power);



        }
    }
    
}

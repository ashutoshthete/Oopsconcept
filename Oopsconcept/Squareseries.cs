using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class Squareseries
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the range");
            int num = int.Parse(Console.ReadLine());
            int i = 1;
            while (i <= num)
            {
                Console.Write(i*i+" ");
                i++;
            }
        }
    }
}

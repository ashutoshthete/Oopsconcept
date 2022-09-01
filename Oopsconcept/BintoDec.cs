using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class BintoDec
    {
       /* public int Power(int b, int index)
        {
            int power = 1;
            for (int i = 1; i <= index; i++)
            {
                power = power * index;

            }
            return power;
        }*/
        static void Main(string[] args)
        {
            BintoDec bd = new BintoDec();
            Console.WriteLine("enter binary value : ");
            int num = int.Parse(Console.ReadLine());

            int dnum = 0;
            /*int count = 0;*/
            int basev = 1;

            while (num > 0)
            {
                int r = num % 10;
                dnum = dnum + r*basev;
                num = num / 10;
                basev = basev * 2;


            }
            Console.WriteLine("decimal : "+dnum);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class BintoDec
    {
       public int Bin(int num)
        {
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
            return dnum;
        }
        static void Main(string[] args)
        {
            BintoDec bd = new BintoDec();
            Console.WriteLine("enter binary value : ");
            int num = int.Parse(Console.ReadLine());
            int result = bd.Bin(num);
            Console.WriteLine(result);

           
           

        }
    }
}

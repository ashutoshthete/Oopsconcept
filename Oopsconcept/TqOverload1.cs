using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class TqOverload1
    {
        public void Number(int num)
        {
            int sum = 0;
            while (num != 0)
            {
                int r = num % 10;
                if (r % 2 == 0)
                {
                    sum = sum + r;
                }
                num = num / 10;
            }
           
            Console.WriteLine("The sum of even digit is "+sum);
        }
        public void Number(int n1,int d) 
        {
            int f = 0;
            while (n1 != 0)
            {
                int r = n1 % 10;
                if (r == d)
                {
                    f++;
                }
                n1 = n1 / 10;

            }
            Console.WriteLine("The frequency of digit is:" + d + "=" + f);

        }
        public static void Main(string[] args)
        {
            TqOverload1 to1 = new TqOverload1();
            to1.Number(126545313);
            to1.Number(2565685, 5);

        }
    }
}

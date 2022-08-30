using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class DecimaltoBinary
    {
        public  int DectoBin(int num)
        {
            int bnum = 0;
            int count = 0;
            while (num != 0)
            {
                int r = num % 2;
                int c = (int)Math.Pow(10, count);
                bnum = bnum + (r * c);
                num = num / 2;
                count++;
            }
            return bnum;
        }

        static void Main(string[] args)
        {
            DecimaltoBinary db = new DecimaltoBinary();
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            int res = db.DectoBin(num);
            Console.WriteLine(res);

            
        }
        

    }
}

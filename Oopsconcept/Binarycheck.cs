using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class Binarycheck
    {
       
        public bool Isbinary(int num)
        {
            int c = 0;
            while (num > 0)
            {

                int r = num % 10;
                c++;
                if (c%2==1)
                {
                    if (r > 1)
                    {
                        return false;
                    }
                }
                num = num / 10;
 
            }
            return true;
        }
        static void Main(string[] args)
        {
            Binarycheck br = new Binarycheck();
            Console.WriteLine("enter number to check binary or not");
            int num = int.Parse(Console.ReadLine());

            bool res = br.Isbinary(num);
            if (res)
            {
                Console.WriteLine("binary number");
            }
            else
            {
                Console.WriteLine("not binary");
            }
           
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class Class3
    {
        public int firstd(int num)
        {
            while (num >= 10) {
                num = num / 10;
            }
            return num;
        }
        public int lastd(int num)
        {
            int r;
            r = num % 10;
            return r;
        }
        static void Main(string[] args)
        {
            Class3 c3 = new Class3();
            Console.WriteLine("enter");
            int num = int.Parse(Console.ReadLine());
            int result1 = c3.firstd(num);
            int result2 = c3.lastd(num);

            Console.WriteLine("f "+result1+"\nl "+result2);
        }
    }
}

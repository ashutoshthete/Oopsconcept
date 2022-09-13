using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class Class10
    {
        public  int Count(int num)
        {
            int c = 0;
            while (num>= 10)
            {


                c++;
                num = num / 10;
                
            }
            return num;
        }
        public static void Main(string[] args)
        {
            Class10 ct = new Class10(); 

            Console.WriteLine("enter the number ");
            int num = int.Parse(Console.ReadLine());
            int result = ct.Count(num);
            Console.WriteLine(result);
        }
    }
}

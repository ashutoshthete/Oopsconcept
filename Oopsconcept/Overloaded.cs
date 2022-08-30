using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class Overloaded
    {
        public void numcal(int num,char ch)
        {
            int sum = 0;
            if (ch == 's')
            {
                sum = num * num;
            }
            else
            {
                sum = num * num * num;
            }
            Console.WriteLine("Square/Cube = " + sum);

        }


        public void numcal(int a, int b,char ch)
        {
            int c = 0;
            if (ch == 'p')
            {
                c = a * b;
            }
            else
            {
                c = a + b;
            }
            Console.WriteLine("Answer = "+c);

        }
        public static void Main(string[] args)
        {
            Overloaded o1 = new Overloaded();
            o1.numcal(12, 's');
            o1.numcal(12, 11, 'p');
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    interface IClass7
    {
        void add(int a, int b);
        void substract(int a, int b);

    }
    interface Scical : IClass7
    {
        void tan(int a);
        void cos(int angle);
    }
    class Thinkcalculator : Scical
    {
        public void add(int a,int b)
        {
            Console.WriteLine("sum"+(a+b));
        }
        public void cos(int angle)
        {
            Console.WriteLine("sum"+Math.Cos(angle));
        }
        public void tan(int a)
        {
            Console.WriteLine("sum" + Math.Tan(a));
        }
        public void substract(int a,int b)
        {
            Console.WriteLine("sum" + (a-b));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class MethodOverloading
    {
        public void area(int l, int b)
        {
           int arearectangle = l * b;
            Console.WriteLine("rectangle-"+arearectangle);
        }
        public void area(double r)
        {
            double areacircle = 3.14 * r * r;
            Console.WriteLine("circle-"+areacircle);
        }
        public void area(int side)
        {
            int areasquare = side * side;
            Console.WriteLine("square-"+areasquare);
        }
        static void Main(string[] args)
        {
            MethodOverloading c1 = new MethodOverloading();
            c1.area(16.44);
            c1.area(24);
            c1.area(24, 12);
        }
    }
}

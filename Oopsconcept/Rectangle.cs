using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class Rectangle
    {
        int length, breadth, area, perimeter;
        public void input()
        {
            Console.WriteLine("enter length");
            length = int.Parse(Console.ReadLine());
            Console.WriteLine("enter breadth");
            breadth = int.Parse(Console.ReadLine());
        }
        public void calculate()
        {
            perimeter = 2 * (length + breadth);
            area = length * breadth;
            

        }
        public void display()
        {
            Console.WriteLine("perimeter of Recatangle="+perimeter);
            Console.WriteLine("area of Reactangle="+area);
        }
        public static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.input();
            r.calculate();
            r.display();
            
        }
    }
}

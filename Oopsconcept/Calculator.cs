using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class Calculator
    {
       
        int a, b, c;
        public void readdata()
        {
            Console.WriteLine("enter first number");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second number");
            b = int.Parse(Console.ReadLine());
        }
        public int add()
        {
            c = a + b;
            Console.WriteLine("addition="+c);
            return c;
        }
        public void sub()
        {
            c = a - b;
            Console.WriteLine("substraction="+c);
        }
        public int mul()
        {
            c = a * b;
          //  Console.WriteLine("multiplication="+c);
            return c;

        }
        public float Div()
        {
            c = a / b;
            Console.WriteLine("division="+c);
            return c;
        }
        public static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            calc.readdata();
           int sum= calc.add();
            calc.sub();
           float quot= calc.Div();
           int prod= calc.mul();
            
        }
    }
    
}

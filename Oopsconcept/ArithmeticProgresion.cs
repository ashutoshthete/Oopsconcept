using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class ArithmeticProgresion
    {
        static void ShowAP(int a,int diff,int n)
        {
            int temp;
            temp = a;
            for(int i = 1; i <= n; i++)
            {
                Console.Write(temp+" ");
                temp = temp + diff;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter starting number : ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Common difference : ");
            int diff = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the N th term to be find");
            int n = int.Parse(Console.ReadLine());

            ShowAP(a, diff, n);
        }
    }
    class Ap
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 4;
            int result = b;
            int diff = b - a;
            Console.WriteLine("first number is : "+a+"\nsecind number is : "+b);

            Console.WriteLine("Enter the Nth index : ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 3; i <= n; i++)
            {
                result = result + diff;
            }
            Console.WriteLine(result);
        }
    }
}

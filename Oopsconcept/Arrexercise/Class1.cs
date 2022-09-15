using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept.Arrexercise
{
    class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

        }
    }
}

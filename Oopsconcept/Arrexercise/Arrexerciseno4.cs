using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept.Arrexercise
{
    class Arrexerciseno4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array : ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr1 = new int[size];
            int[] arr2 = new int[size];
            Console.WriteLine("enter the elements of array : ");
            for(int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = arr1[i];
            }
            Console.WriteLine("\nOriginal array element : ");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write("  "+arr1[i]);
            }
            Console.WriteLine("\ncopy of array element : ");
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write("  "+arr2[i]);
            }

        }
    }
}

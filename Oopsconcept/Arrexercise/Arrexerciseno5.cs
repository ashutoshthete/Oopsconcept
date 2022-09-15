using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept.Arrexercise
{
    class Arrexerciseno5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the size of array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter the Array elemenet : " );
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i]= Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\nArray elements : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(" "+arr[i]); 
            }
            Console.WriteLine("\nReverse Array elements : ");
            for(int i = arr.Length - 1; i >=0; i--)
            {
                Console.Write(" " + arr[i]);
            }
        }
    }
}

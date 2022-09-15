using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept.Arrexercise
{
    class Arrexerciseno2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array : ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[]arr = new int[size];
            Console.WriteLine("Enter the elements of array :");
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            int sum = 0;
            int avg = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            avg = sum / arr.Length;
            Console.WriteLine("the average of array element is : "+avg);
        }
    }
}

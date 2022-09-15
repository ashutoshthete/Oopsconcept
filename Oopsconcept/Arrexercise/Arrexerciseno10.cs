using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept.Arrexercise
{
    class Arrexerciseno10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size : ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int max = arr[0];
            int min = arr[0];
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Max : "+max);
            Console.WriteLine("Min : "+min);

        }
    }
}

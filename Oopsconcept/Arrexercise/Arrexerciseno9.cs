using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept.Arrexercise
{
    class Arrexerciseno9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array : ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            int[] odd = new int[size];
            int[] even = new int[size];
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int e = 0;
            int o = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    even[e] = arr[i];
                    e++;
                }
                else
                {
                    odd[o] = arr[i];
                    o++;
                }
                
            }
            Console.WriteLine("even :");
            if (e > 0)
            {
                for(int i = 0; i < e ; i++)
                {
                    Console.WriteLine(" "+even[i]);
                }
               
            }
            Console.WriteLine("odd :");
            if (o > 0)
            {
                for (int i = 0; i < o; i++)
                {
                    Console.WriteLine(" " + odd[i]);
                }
                
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept.Arrexercise
{
    class Arrexerciseno7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine("\nenter the element you want to insert in array : ");
            int inele = int.Parse(Console.ReadLine());
            Console.WriteLine("\nenter the position at where you want to insert : ");
            int pos= int.Parse(Console.ReadLine());
            int[] newarr = new int[size + 1];

            for(int i = 0; i < size + 1; i++)
            {
                if (i < pos - 1)
                {
                    newarr[i] = arr[i];
                }else if (i == pos - 1)
                {
                    newarr[i] = inele;
                }
                else
                {
                    newarr[i] = arr[i - 1];
                }
            }
            for(int i = 0; i < size + 1; i++)
            {
                Console.Write(newarr[i]+" ");
            }
        }
    }
}

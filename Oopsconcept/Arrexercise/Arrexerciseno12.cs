using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept.Arrexercise
{
    class Arrexerciseno12
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size : ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            int smallest = int.MaxValue;
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < smallest)
                {
                    smallest=arr[i];
                }

            }
            Console.WriteLine("Smallest : "+smallest);

            int secondsmallest = int.MaxValue;
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i]<secondsmallest && arr[i] > smallest)
                {
                    secondsmallest = arr[i];
                }
            }
            Console.WriteLine("second smallest : "+secondsmallest);
            
        }
    }
}

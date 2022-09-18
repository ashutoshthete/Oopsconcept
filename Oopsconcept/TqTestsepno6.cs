using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class TqTestsepno6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size:");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            int temp = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Original array: ");
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.Write("sorted array : ");
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                        
                    }
                }
            }
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write (arr[i]+" ");
            }
        }
    }
}

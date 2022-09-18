using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class TqTestsepno2
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size :");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Original array");
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine("\nPrime numbers in array are : ");
            for(int i = 0; i < arr.Length; i++)
            {
                int count = 0;
                for(int j = 2; j < arr[i]; j++)
                {
                    if (arr[i] % j == 0)
                    {
                        count = 1;
                        break;
                    }

                }
                if (count == 0)
                {
                    Console.Write(arr[i]+" ");
                }
            }
            Console.WriteLine("\nEven number in array are : ");
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.Write(arr[i]+" ");
                }
            }
        }
    }
}

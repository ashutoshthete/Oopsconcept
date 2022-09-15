using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept.Arrexercise
{
    class Arrexerciseno11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the size");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            int count = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }
            for(int i = 0; i < size; i++)
            {
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        break;
                    }
                }
            }
            Console.WriteLine("the total number of duplicate in array :"+count);
        }
    }
}

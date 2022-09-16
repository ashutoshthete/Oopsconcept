using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept.Arrexercise
{
    class Arrexerciseno13
    {
        public static void countfreq(int[]arr,int size)
        {
            bool[] ispresent = new bool[size];
            for(int i = 0; i < size; i++)
            {
                if (ispresent[i] == true)
                {
                    continue;
                }
                int count = 1;
                for(int j = i + 1; j < size; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        ispresent[j] = true;
                        count++;
                    }
                }
                Console.WriteLine("Frequency of "+arr[i]+" occurs at "+count);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size :");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            countfreq(arr, size);
           
        }
    }
}

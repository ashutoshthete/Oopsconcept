using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class Test24sepEx4
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
                Console.WriteLine("Frequency of " + arr[i]+" is "+count);
            }
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter the size ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            for(int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            countfreq(arr, size);
        }
    }
}

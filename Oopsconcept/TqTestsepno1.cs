using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class TqTestsepno1
    {
        public static void findpair(int[]arr,int sumtobe)
        {
            for(int i = 0; i < arr.Length - 1; i++)
            {
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == sumtobe)
                    {
                        Console.WriteLine("Pair found : ("+arr[i]+"),("+arr[j]+")");
                    }
                   

                }

            }
            

        }
        public static void Main(string[] args)
        {
            int[] arr = { 5, 4, 6, 8, 9, 7, 25, 6, 44, 25, 38, 44 };
            int sumtobe = 15;
            findpair(arr, sumtobe);

        }
    }
}

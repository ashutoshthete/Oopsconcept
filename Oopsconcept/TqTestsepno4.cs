using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class TqTestsepno4
    {
        public static int missingnumber(int[] arr)
        {
            int n = arr.Length + 1;
            int sum = n * (n + 1) / 2;
            int restsum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                restsum = restsum + arr[i];
            }
            int missingNumber = sum - restsum;
            return missingNumber;
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 8, 9 };
            Console.WriteLine("Missing number is : "+missingnumber(arr));
        }
    }
}

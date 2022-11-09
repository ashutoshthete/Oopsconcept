using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class Class18
    {
        static void printsquare(int[]arr,int n)
        {
            int count = 0;
            for(int i = 0; i < n; i++)
            {
                int square = arr[i] * arr[i];
                for(int j = 0; j < n; j++)
                {
                    if (arr[j] == square)
                    {
                        Console.WriteLine(arr[i]+" has  "+arr[j]+" as a square");
                        count = count + 1;
                    }
                }
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] arr = { 2, 4, 5, 20, 16 };
            int n = arr.Length;
            printsquare(arr, n);
        }
    }
}

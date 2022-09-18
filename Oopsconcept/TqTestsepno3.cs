using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class TqTestsepno3
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 10, 5, 6, 8, 9, 7, 1, 3, 55, 64 };
            int[] arr2 = { 5, 44, 66, 25, 949, 84, 54, 64, 12, 13 };
            
            Console.WriteLine("common elements : ");
           for(int i = 0;i<arr1.Length; i++)
            {
                for(int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        Console.WriteLine(arr1[i]+" ");

                    }
                }

            }
        }
    }
}

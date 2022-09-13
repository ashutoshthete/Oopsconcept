using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class Class11
    {
        public static void findfreq(int[] arr1)
        {
            int freq = 1;
            int idx = 1;
            int element = arr1[0];
            while (idx < arr1.Length)
            {

                if (arr1[idx - 1] == arr1[idx])
                {
                    freq++;
                    idx++;
                }
                else
                {
                    Console.WriteLine(element+"   "+freq);
                    element = arr1[idx];
                    idx++;
                    
                    freq = 1;
                }
            }
            Console.WriteLine(element+ "   " + freq);
        }
        static void Main(string[] args)
        {
            findfreq(new int []{ 5, 5, 4, 1, 1, 2, 3, 3 });
            
           

        }
    }
}

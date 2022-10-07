using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class LongSubArr
    {
        static int maxSubarrLength(int[] arr)
        {
            int maxlen = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                int zeros = 0;
                int ones = 0;
                for(int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] == 0)
                    {
                        zeros++;
                    }
                    else
                    {
                        ones++;
                    }
                    if (zeros == ones)
                    {
                        maxlen = Math.Max(maxlen, j - i + 1);
                    }
                }
            }
            return maxlen;
        }
        static void Main(string[] args)
        {
            int[] arr = { 0, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0, 0, 1 };
            int result = maxSubarrLength(arr);
            Console.WriteLine(result);
        }
    }
}

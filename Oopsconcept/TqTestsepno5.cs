using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class TqTestsepno5
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 45, 84, 965, 458, 61, 254, 974 };
            int largest = int.MinValue;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > largest)
                {
                    largest = arr[i];

                }
            }
            Console.WriteLine("largest "+largest);
            int secondlargest = int.MinValue;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > secondlargest && arr[i] < largest)
                {
                    secondlargest = arr[i];
                }
            }
            Console.WriteLine("Second largset : "+secondlargest);
        }
    }
}

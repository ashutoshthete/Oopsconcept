using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class primesumarr
    {
        
        static void Main(string[] args)
        {
            int count, sum = 0;
            int[] arr = new int[5];

            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i < arr.Length; i++)
            {
                count = 0;
                for (int j = 2; j < arr[i]; j++)
                {
                    if (arr[i] % j == 0)
                    {
                        count++;
                        break;

                    }

                }
                if(count==0 && arr[i] != 1)
                {
                    sum = sum + arr[i];
                }
            }
            Console.WriteLine("prime sum :"+sum);
        }
    }
}

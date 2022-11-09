using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class Class21
    {
        static void CheckPime(int[] arr)
        {
            int p;
            for(int i = 0; i < arr.Length; i++)
            {
                p = 1;
                for(int j = 2; j < arr[i]; i++)
                {
                    if (arr[i] % j == 0)
                    {
                        p = 0;
                        break;
                    }
                    if (p == 1)
                    {
                        Console.Write(arr[i]+" ");
                    }

                }
            }
        }
        static void Main(string[] args)
        {
            int[] arr = new int[5];

            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            CheckPime(arr);
        }
    }
    class class22
    {
        static void printprime(int[] arr)
        {
            int p,j;
            for(int i = 0; i < arr.Length; i++)
            {
                p = 1;
                j = 2;
                while (j < arr[i])
                {
                    if (arr[i] % j == 0)
                    {
                        p = 0;
                        break;
                    }
                    j++;
                }
                if (p == 1)
                {
                    Console.Write(arr[i]+" ");
                }
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            printprime(arr);

        }
    }
}

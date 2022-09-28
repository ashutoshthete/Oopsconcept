using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class Class15
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 3];
            int[] rsum = new int[10];
            int[] csum = new int[10];
            int[] whsum = new int[10];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.WriteLine("element: " + i, j);
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.WriteLine("\n");
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("\t" + arr[i, j] + " ");
                }
            }
            Console.WriteLine("\n");
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                rsum[i] = 0;
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    rsum[i] = rsum[i] + arr[i, j];
                }
                Console.WriteLine("Rowwise sum : "+rsum[i]);
            }

            Console.WriteLine("\n");
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                csum[j] = 0;
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    csum[j] = csum[j] + arr[i, j];
                }
                Console.WriteLine("col wise sum : "+csum[j]);
            }
            Console.WriteLine("\n");
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {

                    sum = sum + arr[i, j];
                }

            }
            Console.WriteLine("the sum of whole array : "+sum);
            Console.WriteLine("\n");

            Console.WriteLine("print left diagonal ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    
                    if (i+j == 2)
                    {
                        Console.Write(arr[i,j]);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n");
            Console.WriteLine("print right diagonal ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {

                for (int j = 0; j < arr.GetLength(1); j++)
                {

                    if (i== j)
                    {
                        Console.Write(arr[i, j]);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("..........");
            int sumlefd = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {

                for (int j = 0; j < arr.GetLength(1); j++)
                {

                    if (i + j == arr.GetLength(1)-1)
                        sumlefd = sumlefd + arr[i, j];

                   
                }
               
            }
            Console.WriteLine("left diagonal sum :"+sumlefd);
            Console.WriteLine("..........");
            int sumrightd = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {

                for (int j = 0; j < arr.GetLength(1); j++)
                {

                    if (i == j)
                        sumrightd = sumrightd + arr[i, j];

                }   
            }
            Console.WriteLine("right diagonal sum : "+sumrightd);
        }
    }
}

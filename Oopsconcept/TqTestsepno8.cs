using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class TqTestsepno8
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[2,3]; 
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
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                int maxcol = arr[0,j];
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    if (maxcol < arr[i, j])
                    {
                        maxcol = arr[i, j];
                    }
                   
                }
                Console.WriteLine("\nCol max :" + j + " = " + maxcol);
            }
            
        }
    }
}

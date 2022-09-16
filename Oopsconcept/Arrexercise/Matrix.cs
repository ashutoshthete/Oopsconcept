using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept.Arrexercise
{
    class Matrix
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the rows :");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of colomns :");
            int col = int.Parse(Console.ReadLine());
            int[,] arr = new int[rows,col];
            for (int i = 0; i < rows; i++)
            {
               
                for(int j = 0; j < col; j++)
                {
                    Console.WriteLine("element :"+i,j);
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            }
            Console.WriteLine("The Matrix is :");
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine("\n");
                for (int j = 0; j < col; j++)
                {
                    Console.Write("\t"+arr[i, j]);
                }

            }

        }
    }
}

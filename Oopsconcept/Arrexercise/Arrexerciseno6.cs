using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept.Arrexercise
{
    class Arrexerciseno6
    {
        public static int average(int[] arr)
        {
            int sum = 0;
            int avg = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            avg = sum / arr.Length;
            return avg;


        }
        public static double average(double[] arr)
        {
            double sum = 0;
            
            double avg = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            avg = sum / arr.Length;
            return avg;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter the size: ");
            int size = int.Parse(Console.ReadLine());
            double[] arr1 = new double[size];
            for(int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("average : "+average(arr1));
            int[] arr2 = new int[size];
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("average : " + average(arr2));

        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept.StringExercise
{
    class StringExercise11
    {
        static int longestwordlength(string str)
        {
            string[] arr = str.Split();
            int wordlength = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (wordlength < arr[i].Length)
                {
                    wordlength = arr[i].Length;
                    Console.WriteLine(arr[i]);
                }
               
            }
            return wordlength;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();
            

            Console.WriteLine(longestwordlength(str));
             
        }
    }
}

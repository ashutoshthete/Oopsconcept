using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept.StringExercise
{
    class StringExercise8
    {
        static void Main(string[] args)
        {
            string str = "my name is ashutosh thete and i am from kannad";
            string[] arr = str.Split();
            
            int countword = 0;
            foreach (string sr in arr)
            {
                Console.WriteLine(sr); 
            }
            Console.WriteLine("the first word of string is : "+arr[0]);

        }
    }
}

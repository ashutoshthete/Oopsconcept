using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept.StringExercise
{
    class StringExercise7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string : ");
            string str = Console.ReadLine(); 
            string[] arr = str.Split();
            int countword = 0;
            foreach(string sr in arr)
            {
                Console.WriteLine(sr);
                countword++;
            }
            Console.WriteLine("The total numbe rof words in string is : " +countword);
        }
    }
}

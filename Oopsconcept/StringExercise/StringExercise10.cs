using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept.StringExercise
{
    class StringExercise10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string str = Console.ReadLine();
            string revstr = "";
            for(int i =(str.Length-1); i>=0; i--)
            {
                revstr = revstr + str[i];

            }
            if (str.ToLower().Equals(revstr.ToLower()))
            {
                Console.WriteLine(str+" is a Palindrome ");
            }
            else
            {
                Console.WriteLine(str+" is not Palindrome ");
            }
        }
    }
}

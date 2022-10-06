using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept.StringExercise
{
    class StringExercise13
    {
        static int findsum(string str)
        {
            string tp = "0";
            int sum = 0;
            for(int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                if (char.IsDigit(ch))
                {
                    tp = tp + ch;
                }
                else
                {
                    sum = sum + int.Parse(tp);
                    tp = "0";
                }
            }
            return sum + int.Parse(tp);
        }
        static void Main(string[] args)
        {
            string str = "my56name57is8ashutosh78";
            Console.WriteLine(findsum(str));

        }
    }
}

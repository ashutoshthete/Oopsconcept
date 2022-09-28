using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept.StringExercise
{
    class StringExercise5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string : ");
            string str = Console.ReadLine();

            int[] freq = new int[str.Length];

            char[] str1 = str.ToCharArray();

            for(int i = 0; i < str.Length; i++)
            {
                freq[i] = 1;
                for(int j = i + 1; j < str.Length; j++)
                {
                    if (str1[i] == str1[j])
                    {

                        freq[i]++;


                        str1[j] = '0';
                    }
                }
            }
            Console.WriteLine("Charcater and their Frequency :");
            for(int i = 0; i < freq.Length; i++)
            {
                if(str1[i]!=' '&& str1[i] != '0')
                {
                    Console.WriteLine(str1[i]+"   -   "+freq[i]);
                }
            }

        }
    }
}

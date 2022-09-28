using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class Test24sepEx6
    {
        static char[] count = new char[300];
        static void getcharcount(string str)
        {
            for(int i = 0; i < str.Length; i++)
            {
                count[str[i]]++;
            }
        }
        static int firstnonrepeating(string str)
        {
            getcharcount(str);
            int index = -1, i;
            for (i = 0; i < str.Length; i++)
            {
                if (count[str[i]] == 1)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        static void Main(string[] args)
        {
            string str = "thinkquotient is the best company to work for";

            int index=firstnonrepeating(str);
            Console.WriteLine(index == -1 ? "Either" + "all character is repeating" + "is empty" : "First non repeating character is  " + str[index]);
            

        }
    }
}

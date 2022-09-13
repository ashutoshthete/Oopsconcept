using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class Class6
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;
            string v = "🍕";
            string v_uni = "\uD83C\uDF55";
            string s1 = "🎁";
            string s1_uni = "\ud83c\udf81"; // unicode code for s1
            string s2 = "☺";
            string s2_uni = "\u263A"; // unicode code for s2
            Console.WriteLine(s1);
            Console.WriteLine(s1_uni);
            Console.WriteLine(s2);
            Console.WriteLine(s2_uni);
            Console.WriteLine(v);
            Console.WriteLine(v_uni);
            Console.ReadLine();

        }
    }
}

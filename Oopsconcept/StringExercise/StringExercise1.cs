using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept.StringExercise
{
    class StringExercise1
    {
        static void Main(string[] args)
        {
            string str = "Ashutosh";
            Console.WriteLine(str);

            string str1 = str + "Thete ";
            Console.WriteLine(str1);

            Console.WriteLine(str.Length);
            Console.WriteLine(str.Replace('s','.'));

            string sp = "thisworld ";
            Console.WriteLine(sp[3]);

            Console.WriteLine(str.Substring(0,4));
            
            Console.WriteLine(sp.IndexOf('w'));
            Console.WriteLine(sp.LastIndexOf('d'));
            sp=sp.ToUpper();
            Console.WriteLine(sp);
            string v = "My name is Ashutosh";
            string[] arr = v.Split();
            foreach(string sv in arr)
            {
                Console.WriteLine(sv);
            }
            
            
        }
    }
}

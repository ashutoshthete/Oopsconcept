using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class Class13
    {
        static void Main(string[] args)
        {

        
        int[] a = { 1, 2, 22, 55, 44 };
        int[] b = { 2, 3, 21, 45, 66 };
        int[] c = new int[a.Length + b.Length];
            int k = 0;
            for(int i = 0; i < a.Length; i++)
            {
                c[k] = a[i];
                k++;
            }
            for(int i = 0; i < b.Length; i++)
            {
                c[a.Length + i] = b[i];
            }
            for(int i = 0; i < c.Length; i++)
            {
                Console.WriteLine(c[i]);
            }
        }
    }
    class Na
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 22, 55, 44 };
            int[] b = { 2, 3, 21, 45, 66, 55, 45, 23 };

            int[] c = new int[a.Length + b.Length];
            int k = 0;
            for(int i = 0; i < a.Length; i++)
            {
                c[k] = a[i];
                k++;
                c[k] = b[i];
                k++;
            }
            for(int i = 0; i < c.Length; i++)
            {
                Console.WriteLine(c[i]);
            }
        }
    }class Ma
    {
      
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 22, 55, 44 };
            int[] b = { 2, 3, 21, 45, 66, 55, 45, 23 };

            int[] c = new int[a.Length + b.Length];
            int k = 0;
            for (int i = 0; i < c.Length;)
            {
                if (k < a.Length && k < b.Length) {
                    c[i] = a[k];
                    i++;
                    c[i] = b[k];
                    i++;
                } else if (k < b.Length)
                {
                    c[i] = b[k];
                    i++;
                }else if (k< a.Length)
                {
                    c[i] = a[k];
                    i++;
                }
                k++;
            }
            for (int i = 0; i < c.Length; i++)
            {
                Console.WriteLine(c[i]);
            }

        }
    }
}

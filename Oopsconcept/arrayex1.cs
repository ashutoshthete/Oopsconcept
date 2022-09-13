using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class arrayex1
    {
        static void Main(string[] args)
        {
            
            int[] arr = new int[5];
            Console.WriteLine("Enter the 5 Elements :");
            for(int i = 0; i < 5; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Elements :"+arr[i]);
            }
            int ev = 0, od = 0;
           for(int i = 0; i < 5; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    
                    Console.WriteLine("even : "+arr[i]);
                    ev++;

                }
                else if (arr[i] != 0)
                {
                    Console.WriteLine("odd : "+arr[i]);
                    od++;
                }
                
            }
            Console.WriteLine("Count of even =" + ev);
            Console.WriteLine("Count of odd =" + od);
        }
    }
    class arrayex2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size :");
            int s = int.Parse(Console.ReadLine());
            int[] arr3 = new int[s];
            int c = 0;
            for(int i = 0; i < arr3.Length; i++)
            {
                arr3[i] = int.Parse(Console.ReadLine());
                if (arr3[i] % 5 == 0)
                {
                    arr3[i] = arr3[i] + 5;
                    Console.WriteLine(" "+arr3[i]);
                    c++;
                    

                }
            }
            Console.WriteLine("count: "+c);
        }
    }
}

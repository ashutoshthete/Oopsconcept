using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class Class12
    {
        public static int dig(int num)
        {
            int count = 0;
            int newCount = 0;
            while (num>0)
            {
                int newNum = num;
                Console.WriteLine(num);
                /*if(num % 10==d)*/
                while (newNum > 0)
                {
                  
                    Console.WriteLine("new"+newNum);
                    newCount++;
                       newNum = newNum / 10;
                }
                
                count++;
                num = num / 10;
                
            }
            return count;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("enter");
            int num = 122345;
            

            Console.WriteLine(dig(num));
            
        }
    }
    class BB
    {
        public static void Main(string[]args)
        {
            
            int[] digit = new int[10];
            
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            int temp = num;
            while (temp > 0)
            {
                int r = temp % 10;
                for(int i = 0; i <= 9; i++)
                {
                    if (r == 1)
                    {

                        
                        
                        digit[temp]++;
                    }
                }
                temp = temp / 10;
            }
            Console.WriteLine("original : "+num);
            for(int i = 0; i <= 9; i++)
            {
                if (digit[i] != 0)
                {
                    Console.WriteLine("Freqyuency of  "+i+" is  "+digit[i]);
                }
            }


        }
    }
}

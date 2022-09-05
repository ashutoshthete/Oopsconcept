using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class TestExercise1
    {
        static void Main(string[] args)
        {
            
            for (int r = 1; r <= 5; r++)
            {
                if (r == 2 || r == 4)
                {
                    char ch = 'A';
                    for (int c = r; c <= 5; c++, ch++)
                    {
                        Console.Write(ch + "");

                    }
                }
                else
                {
                    if (r == 1 || r == 3 || r == 5)
                    {
                        int num = 1;
                        for (int c = r; c <= 5; c++,num++)
                        {

                            Console.Write(num + "");
                        }
                    }
                }
                Console.WriteLine();
            }
            

            for (int r = 2; r <= 5; r++)
            {
                if (r == 2 || r == 4)
                {
                    char ch = 'A';
                    for (int c = 1; c <= r; c++, ch++)
                    {
                        Console.Write(ch + "");
                    }
                }
                else
                {
                    for(int c = 1; c <= r; c++)
                    {
                        Console.Write(c+"");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");


            
            










        }
    }
}

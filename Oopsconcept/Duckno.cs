using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class Duckno
    {
        static void Main(string[] args)
        {
            int dno, dkno, r;
            int c = 0;
            Console.WriteLine();
            for (dkno = 1; dkno <= 100; dkno++)
            {
                dno = dkno;
                c = 0;
                while (dno > 0)
                {
                    if (dno % 10 == 0)
                    {
                        c = 1;
                        break;
                    }
                    dno = dno / 10;
                }
                if (dno > 0 && c == 1)
                {
                    Console.WriteLine(" "+dkno);
                }
            }
        }
       
       
    }
}

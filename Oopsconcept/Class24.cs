using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Oopsconcept
{
    public class Test
    {
        public static void run()
        {
            for(int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }

        }
        
    }
    public class program
    {
        static void Main(string[] args)
        {
            Test test = new Test();

            Thread t1 = new Thread(new ThreadStart(Test.run));
            Thread t2 = new Thread(new ThreadStart(Test.run));
            t1.Name = "Thread 1";
            t2.Name = "Thread 2";
            t1.Priority = ThreadPriority.Highest;
            t2.Priority = ThreadPriority.Lowest;
            t1.Start();
            t2.Start();

        }
    }
}

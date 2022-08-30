using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class Time
    {
        int hour;
        int min;
        int seconds;
        public void Settime()
        {
            Console.WriteLine("enter the hour:");
            hour = int.Parse(Console.ReadLine());
            Console.WriteLine("enter minutes");
            min = int.Parse(Console.ReadLine());
            Console.WriteLine("enter minutes");
            seconds = int.Parse(Console.ReadLine());
        }
        public void Showtime()
        {
            Console.WriteLine("Hour: "+hour);
            Console.WriteLine("Min: "+min);
            Console.WriteLine("Second: "+seconds);
        }
        public static void Main(string[] args)
        {
            Time t = new Time();
            t.Settime();
            t.Showtime();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class Movie
    {
        string moviename;
        string actorname;
        float rating;
        int releaseyear;

        public String Moviename
        {
            set { moviename = value; }
            get { return moviename; }
        }

        public String Actorname
        {
            set { actorname = value; }
            get { return actorname; }
        }

        public float Rating
        {
            set { rating = value; }
            get { return rating; }
        }

        public int Releaseyear
        {
            set { releaseyear = value; }
            get { return releaseyear; }
        }
       
        static void Main(string[] args)
        {
            Movie m1 = new Movie();
            m1.Moviename = " The Grey Man";
            m1.Actorname = " Ryan Gosling";
            m1.Rating = 6.5f;
            m1.Releaseyear = 2022;

            Console.WriteLine("Movie Name ="+m1.Moviename+"\nActor name ="+m1.Actorname+"\nRating = " + m1.Rating+"\nRelease Year = " + m1.Releaseyear);
        }
    }
}

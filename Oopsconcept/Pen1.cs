using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class Pen1
    {
        int caplength;
        string brand;
        Refill r;
        public Pen1(int caplength, string brand, Refill r)
        {
            this.Caplength = caplength;
            this.Brand = brand;
            this.R = r;

        }

        public int Caplength
        {
            set { caplength = value; }
            get { return caplength; }
        }
        public string Brand
        {
            set { brand = value; }
            get { return brand; }
        }
        public Refill R
        {
            set { r = value; }
            get { return r; }
        }
    }
    class Refill
    {
        string inkcolor;
        int length;
        Nib t;

        public Refill(string inkcolor, int length, Nib t)
        {
            this.Inkcolor = inkcolor;
            this.Length = length;
            this.T = t;
        }

        public string Inkcolor
        {
            set { inkcolor = value; }
            get { return inkcolor; }
        }
        public int Length
        {
            set { length = value; }
            get { return length; }
        }
        internal Nib T
        {
            set { t = value; }
            get { return t; }
        }
    }
    class Nib
    {
        string materialtype;
        string width;

        public Nib(string materialtype, string width)
        {
            this.Materialtype = materialtype;
            this.Width = width;
        }

        public string Materialtype { get => materialtype; set => materialtype = value; }
        public string Width { get => width; set => width = value; }
    }
    class Testpen
    {
        public static void Main(string[] args)
        {
            Pen1 tp = new Pen1(10,"Cello",new Refill("Blue",8,new Nib("Plastic","0.05 MM")));
            Console.WriteLine("Cap Length : "+tp.Caplength+"\nPen Brand : "+tp.Brand+"\nPen InkColor : "
                +tp.R.Inkcolor+"\nLength : "+tp.R.Length+"\nMaterial Type : "+tp.R.T.Materialtype+"\nWidth : "+tp.R.T.Width);


        }
    }
}

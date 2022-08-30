using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class Pen
    {
        string penbrand;
        int penprice;
        string pencolor;

        public string Penbrand
        {
            set { penbrand = value; }
            get { return penbrand; }
            
        }
        public int Penprice
        {
            set { penprice = value; }
            get { return penprice; }
        }
        public string Pencolor
        {
            set { pencolor = value; }
            get { return pencolor; }
        }
        public Pen(string penbrand, int penprice, string pencolor)
        {
            this.penbrand = penbrand;
            this.penprice = penprice;
            this.pencolor = pencolor;

        }


    }
    class Compass
    {
        string compassbrand;
        int price;
        string ccolor;
        Pen p;

        public string Compassbrand
        {
            set { compassbrand = value; }
            get { return compassbrand; }
        }
        public int Price
        {
            set { price = value; }
            get { return price; }
        }
        public string Ccolor
        {
            set { ccolor = value; }
            get { return ccolor; }
        }
        Pen P
        {
            set { p = value; }
            get { return p; }
        }
        static void Main(string[] args)
        {
            Compass c1 = new Compass();
            c1.Compassbrand = "Camlin";
            c1.Price = 485;
            c1.Ccolor = "yellow";

            
            Pen p1 = new Pen("Parker", 463, "black");
            c1.P = p1;
            Console.WriteLine(c1.Compassbrand);
            Console.WriteLine(c1.Price);
            Console.WriteLine(c1.Ccolor);
            Console.WriteLine("\npen deatils");
            Console.WriteLine(c1.P.Penbrand);
            Console.WriteLine(c1.P.Penprice);
            Console.WriteLine(c1.P.Pencolor);
        }


    }
    
   
   
}

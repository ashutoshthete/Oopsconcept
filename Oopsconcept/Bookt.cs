using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class Bookt
    {
        string titlebook;
        string authorname;
        double price;

        public Bookt(string title,string author,double price)
        {
            this.titlebook = title;
            this.authorname = author;
            this.price = price;
        }
        static void Main(string[] args)
        {
          Bookt bt = new Bookt("Developing Java Software", "Russel Winderand", 79.75);
            Console.WriteLine("Tile:" + bt.titlebook + "\nAuthor:" + bt.authorname + "\nPrice:" + bt.price);

        }
    }
}

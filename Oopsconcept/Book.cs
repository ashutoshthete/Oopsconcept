using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class Book
    {
        string name;
        int price;
        string authorname;

        public String Name
        {
            set { name = value; }
            get { return name; }
        }


        public int Price
        {
            set { price = value; }
            get { return price; }
        }

        public String Authorname
        {
            set { authorname = value; }
            get { return authorname; }
        }

        static void Main(string[] args)
        {
            Book b1 = new Book();
            b1.Name = "Suheldev";
            b1.Price = 679;
            b1.Authorname = "Amish Tripathi";

            Console.WriteLine("book name - "+b1.Name+"\nPrice - "+b1.Price+"\nAuthor name - "+b1.Authorname);
        }
    }
}

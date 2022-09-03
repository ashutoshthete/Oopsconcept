using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class Bank
    {
        string bankname;
        string branch;
        string address;
        string ifsc;

        public string Bankname { get => bankname; set => bankname = value; }
        public string Branch { get => branch; set => branch = value; }
        public string Address { get => address; set => address = value; }
        public string Ifsc { get => ifsc; set => ifsc = value; }

        
        public void Display()
        {
            Console.WriteLine(Bankname);
            Console.WriteLine(Branch);
            Console.WriteLine(Address);
            Console.WriteLine(Ifsc);

        }
    }
    class HDFC : Bank
    {
        static void Main(string[] args)
        {
            HDFC h = new HDFC();
           
           
            h.Bankname = "hdfc";
            h.Branch = "kannad";
            h.Address = "kannad sambhajinagar";
           
            h.Display();
            
        }
    }   
}

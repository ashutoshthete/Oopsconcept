using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class Order
    {
        public int orderid;
        public string orderdate;
        public Customer cust;
        public Item item;

        public Order(int orderid, string orderdate, Customer cust, Item item)
        {
            this.orderid = orderid;
            this.orderdate = orderdate;
            this.cust = cust;
            this.item = item;
        }


    }
    class Customer
    {
        public int custid;
        public string custname;
        public Address address;
        public Customer(int custid,string custname,Address address)
        {
            this.custid = custid;
            this.custname = custname;
            this.address = address;
        }

    }
    class Address
    {
        string addr1;
        string city;
        int pincode;
        public Address(string addr1,string city,int pincode)
        {
            this.addr1 = addr1;
            this.city = city;
            this.pincode = pincode;
        }
        public string Addr1
        {
            set { addr1 = value; }
            get { return addr1; }
        }
        public string City
        {
            set { city = value; }
            get { return city; }
        }
        public int Pincode
        {
            set { pincode = value; }
            get { return pincode; }
        }
        

    }
    class Item
    {
        int itemid;
        string itemname;
        int itemprice;
        public Item(int itemid,string itemname,int itemprice)
        {
            this.itemid = itemid;
            this.itemname = itemname;
            this.itemprice = itemprice;
        }
        public int Itemid
        {
            set { itemid = value; }
            get { return itemid; }
        }
        public string Itemname
        {
            set { itemname = value; }
            get { return itemname; }
        }
        public int Itemprice
        {
            set { itemprice = value; }
            get { return itemprice; }
        }

    }
    class TestOrder
    {
        static void Main(string[] args)
        {
            Order or = new Order(4521, "12/02/22", new Customer(245, "Ashu", new Address("Kannad","Sambhajinagr",431103)), new Item(255,"Modak",255));
            
            Console.WriteLine("Order Id : "+or.orderid+"\nOrder Date : "+or.orderdate+"\nCustomer Id : "+or.cust.custid+"\nCustomer Name : "+or.cust.custname
                +"\nCustomer address : "+or.cust.address.Addr1+"\nCustomer City : "+or.cust.address.City+"\nCustomer Pincode : "+or.cust.address.Pincode
                +"\nItem Id : "+or.item.Itemid+"\nItem Name : "+or.item.Itemname+"\nItem Price : "+or.item.Itemprice);



        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class Order
    {
         int orderid;
         string orderdate;
         Customer cust;
         Item item;

        public Order(int orderid, string orderdate, Customer cust, Item item)
        {
            this.orderid = orderid;
            this.orderdate = orderdate;
            this.cust = cust;
            this.item = item;
        }
        public int Orderid
        {
            set { orderid = value; }
            get { return orderid; }
        }
        public string Orderdate
        {
            set { orderdate = value; }
            get { return orderdate; }
        }
        public Customer Cust
        {
            set { cust = value; }
            get { return cust; }
        }
        public Item Item1
        {
            set { item = value; }
            get { return item; }
        }



    }
    class Customer
    {
         int custid;
         string custname;
         Address address;
         public Customer(int custid,string custname,Address address)
        {
            this.custid = custid;
            this.custname = custname;
            this.address = address;
        }
        public int Custid
        {
            set { custid = value; }
            get { return custid; }
        }
        public string Custname
        {
            set { custname = value; }
            get { return custname; }
        }
        public Address Address1
        {
            set { address = value; }
            get { return address; }
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
            
            Console.WriteLine("Order Id : "+or.Orderid+"\nOrder Date : "+or.Orderdate+"\nCustomer Id : "+or.Cust.Custid+"\nCustomer Name : "+or.Cust.Custname
                +"\nCustomer address : "+or.Cust.Address1.Addr1+"\nCustomer City : "+or.Cust.Address1.City+"\nCustomer Pincode : "+or.Cust.Address1.Pincode
                +"\nItem Id : "+or.Item1.Itemid+"\nItem Name : "+or.Item1.Itemname+"\nItem Price : "+or.Item1.Itemprice);



        }
    }
}

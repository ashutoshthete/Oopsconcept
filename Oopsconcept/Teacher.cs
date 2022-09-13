using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    public abstract class Teacher
    {
        int tid;
        string tname;
        long mobileno;
        

       

        public Teacher(int tid, string tname, long mobileno)
        {
            this.tid = tid;
            this.tname = tname;
            this.mobileno = mobileno;
        }

        public int Tid
        {
            set { tid = value; }
            get { return tid; }
        }
        public string Tname
        {
            set { tname = value; }
            get { return tname; }
        }
        public long Mobileno
        {
            set { mobileno = value; }
            get { return mobileno; }
        }
        public override string ToString()
        {
            return "Teacher name: " + Tname + "\nTeacher ID : " + Tid + "\nMobile No : " + Mobileno;
        }


        public abstract int Salary();


    }
    class Hourlybased:Teacher
    {
        int rateperhour;
        int hrs;


        public Hourlybased(int tid,string tname,long mobileno ,int rateperhour, int hrs) : base(tid,tname, mobileno)
        {
            this.rateperhour = rateperhour;
            this.hrs = hrs;
            

        }

        public int Rateperhour {  set { rateperhour = value; } get { return rateperhour; } }
        public int Hrs { set { hrs = value; } get { return hrs; } }
        
        public override int Salary()
        {
            int result = rateperhour * hrs;
            return result;
        }
        public override string ToString()
        {
            return "Teacher name: " + Tname + "\nTeacher ID : " + Tid + "\nMobile No : " + Mobileno+"\nSalary :"+Salary()+"\n";
        }

    }
    class Salarybased:Teacher
    {
        int salary;
        

        public Salarybased(int tid, string tname, long mobileno,int salary) : base(tid, tname, mobileno)
        {
            this.salary = salary;
        }
        public override int Salary()
        {
            return salary;
        }
        public override string ToString()
        {
            return "Teacher name: " + Tname + "\nTeacher ID : " + Tid + "\nMobile No : " + Mobileno + "\nSalary :" + Salary()+"\n";
        }


    }

    class Batch
    {
        string batname;
        string coursename;
        Teacher t;

        public Batch(string batname, string coursename, Teacher t)
        {
            this.Batname = batname;
            this.Coursename = coursename;
            this.T = t;
        }

        public string Batname { get => batname; set => batname = value; }
        public string Coursename { get => coursename; set => coursename = value; }
        public Teacher T { get => t; set => t = value; }
    }
    class testteacher
    {
        static void Main(string[] args)
        {



            Batch b = new Batch("Wipro", "C#", new Hourlybased(1, "deepa", 98777777, 1000, 10));
            b.T.Salary();

            
           /* Hourlybased hb = new Hourlybased(4125, "ashutosh", 97656789, 2000, 4);
            Console.WriteLine(hb);
           ;
            Salarybased sb = new Salarybased(25598, "pruthviraj", 9786458715, 160000);
            Console.WriteLine(sb);
            Salarybased sb1 = new Salarybased(25598, "pruthviraj", 9786458715, 160000);
            Console.WriteLine(sb1);*/

        }
    }
    
}

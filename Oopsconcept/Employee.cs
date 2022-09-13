using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class Employee
    {
        long employeeid;
        string employeename;
        Department d;

        public Employee(long employeeid,string employeename,Department d)
        {
            this.employeeid = employeeid;
            this.employeename = employeename;
            this.d = d;
        }

        public long Employeeid
        {
            set { employeeid = value; }
            get { return employeeid; }
        }
        public String Employeename
        {
            set { employeename = value; }
            get { return employeename; }
        }
        public Department D
        {
            set { d = value; }
            get { return d; }
        }
        public override string ToString()
        {
            return "Employee ID : "+employeeid+"\nEmployee Name : "+employeename;
        }
        

    }
    class Department
    {
        int depid;
        string depname;
        public Department(int depid,string depname)
        {
            this.Depid = depid;
            this.Depname = depname;
        }

        public int Depid { get => depid; set => depid = value; }
        public string Depname { get => depname; set => depname = value; }
        public override string ToString()
        {
            return "Department ID : "+depid+"\nDepartment Name : "+depname;
        }
    }
    
    class TestEmployee
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(21202015,"Ashutosh Thete",new Department(25598,"Administration"));
            /*Console.WriteLine("Employee Name : " +emp.Employeename+"\nEmployee Id : "+emp.Employeeid+"\nDepartment Id : "+emp.D.Depid+"\nDepartment Name : "+emp.D.Depname);*/
            Department dp=new Department(25598, "Administration");
            Console.WriteLine(emp+""+dp);
            Employee emp1 = new Employee(21230015, "Anup Kumar", new Department(25688, "Administration"));
            Console.WriteLine(emp1);
        }
    }
}

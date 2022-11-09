using System;
using System.Collections.Generic;
using System.Text;

using System.Data.SqlClient;
namespace Oopsconcept
{
    class demoADOnet
    {
        static void Main(string[] args)
        {
            string connectionstring = "server=DESKTOP-BI1L5MM\\SQLEXPRESS;Database=HR;Integrated Security=true";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlCommand cmd = new SqlCommand("select*from employees", con);

            SqlDataReader reader=cmd.ExecuteReader();

            while (reader.Read())
            {

                Console.WriteLine(reader["employee_id"] + " " + reader["first_name"]+" "+reader[2]);
            }

        }
    }
    class demoinsert
    {
        static void Main(string[] args)
        {
            string connectionstring = "server=DESKTOP-BI1L5MM\\SQLEXPRESS;Database=Ashutosh;Integrated Security=true";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into book values(@bookid,@bookname,@price,@authorid)", con);
            
            Console.WriteLine("Enter bookid: ");
            int bookid = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter bookname : ");
            string bookname = Console.ReadLine();

            Console.WriteLine("Enter price :");
            int price = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter author id :");
            int autid = int.Parse(Console.ReadLine());

            cmd.Parameters.AddWithValue("@bookid", bookid);
            cmd.Parameters.AddWithValue("@bookname", bookname);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@authorid", autid);

            int c = cmd.ExecuteNonQuery();
            if(c>0)
                Console.WriteLine("record inserted succesfully");



        }
    }
    class demoupdate
    {
        static void Main(string[] args)
        {
            string connectionstring = "server=DESKTOP-BI1L5MM\\SQLEXPRESS;Database=Ashutosh;Integrated Security=true";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlCommand cmd = new SqlCommand("update book set price=@price where bookid=@bookid", con);

            Console.WriteLine("Enter bookid: ");
            int bookid = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter price :");
            int price = int.Parse(Console.ReadLine());

            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@bookid", bookid);
            int c = cmd.ExecuteNonQuery();
            Console.WriteLine("records updated: "+c);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsconcept
{
    class Account
    {
        string accountholdername;
        long accountnumber;
        string bankname;
        long deposit;
        long balance;
        long withdraw;

        public String Accountholdername
        {
            set { accountholdername = value; }
            get { return accountholdername; }
        }
        public long Accountnumber
        {
            set { accountnumber = value; }
            get { return accountnumber; }
        }
        public String Bankname
        {
            set { bankname = value; }
            get { return bankname; }
        }
        public long Deposit
        {

            
            set { deposit = value; }
            get { return deposit; }
        }
        public long Balance
        {
            set { balance = value; }
            get { return balance; }
        }
        public long Withdraw
        {
            set { withdraw = value; }
            get { return withdraw; }
        }
        
       

        static void Main(string[] args)
        {
            Account a1 = new Account();
            Console.WriteLine("Enter the Account Hoder Name ");
            a1.Accountholdername = Console.ReadLine();
            Console.WriteLine("Enter the Account number");
            a1.Accountnumber = long.Parse(Console.ReadLine());
            a1.Balance = 100000;
            a1.Bankname = "SBI INDIA";
            Console.WriteLine("\nAccount information-\nAccount Holder Name-"+a1.Accountholdername+"\nAccount Number-"+a1.Accountnumber+"\nBalance-"+a1.Balance+"\nBank Name-"+a1.bankname);
            Console.WriteLine("\n");
            Console.WriteLine("Choose 1 or 2\n1.Withdraw\n2.deposit");

            
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("Enter the amount to withdraw:");
                    a1.Withdraw = long.Parse(Console.ReadLine());
                    a1.Balance = a1.Balance - a1.Withdraw;
                    Console.WriteLine("Amount succesfully withdrawn");
                    Console.WriteLine("Remaining balance-"+a1.Balance);
                    break;
                case 2:
                    Console.WriteLine("Enter the Amount to Deposit-");
                    a1.Deposit = long.Parse(Console.ReadLine());
                    a1.Balance= a1.Balance + a1.Deposit;
                    Console.WriteLine("Amount succesfully deposited");
                    Console.WriteLine("New balance-"+a1.Balance);
                    break;
            }
           
            
            

        }

    }
}

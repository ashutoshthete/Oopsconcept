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

        static void Main(string[] args)
        {
            Account a1 = new Account();
            a1.Accountholdername = "Ashutosh Thete";
            a1.Accountnumber = 884561554;
            a1.Balance = 80000;
            a1.Bankname = "SBI INDIA";
            Console.WriteLine("Deposit=" + (a1.Balance + a1.Deposit));
            

        }

    }
}

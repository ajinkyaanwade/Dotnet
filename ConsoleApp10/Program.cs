using System;
using System.Security.Principal;

namespace basic1
{
    class Account
    {
        static int getid;
        int id;
        string name;
        double balance;
        const int maxcapacity = 2;
        static double interest_rate = 0.07;
        static Account()
        {
            Console.WriteLine("Bank of Baroda");
        }
        public Account(string nm, double bal)
        {
            if (getid < maxcapacity)
            {
                id = ++getid;
                name = nm;
                balance = bal;
            }
            else
                Console.WriteLine(“capacity full can not open account”);
        }
        public void deposit(double amt)
        {
            balance += amt;
        }
        public string display()
        {
            return string.Format("{0}{1}{2}", id, name, balance);
        }
        public static double payint(Account obj)
        {
            double income = obj.balance * interest_rate;
            obj.balance = obj.balance + income;
            return income;
        }
        public void withdraw(double amt)
        {
            const int minbal = 1000;
            if (balance - amt < minbal)
            { //5000-2000
                Console.WriteLine(“insufficient balance ”);
            }
            else
                balance -= amt;
        }

    }
    class AccountDemo
    {
        static void Main()
        {
            Account a1 = new Account("Raj", 1000); // create a  object 
            Account a2 = new Account("Geeta", 40000); // create a object 
            Account a3 = new Account(“Ankit", 5000); // will object  get created? 
          

                    Console.WriteLine(Account.payint(a1));
            a1.deposit(3000);
            a2.deposit(1000);

            Console.WriteLine(a1.display());
            Console.WriteLine(a2.dispay());
            Console.WriteLine(a3.display());

        }
    }
}



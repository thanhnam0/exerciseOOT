using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_3
{
    internal class account
    {
        private string id;
        private string name;
        private int balance;

        public account(string id, string name, int balance)
        {
            this.id = id;
            this.name = name;
            this.balance = balance;
        }
        public string getid()
        {
            return id;

        }
        public string getname()
        {
            return name;

        }
        public int getbalance()
        {
            return balance;

        }
        public void credit(int amount)
        {
            if (amount > 0)
                balance += amount;
        }
        public void debit(int amount)
        {
            if (amount <= balance)
                balance -= amount;
            else
                Console.WriteLine(" Please enter again ");

        }
        public void tranferto(account acc, int amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                acc.balance += amount;

            }
            else
            {
                Console.WriteLine("  no tranfer ");

            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("************ First account information ************");

            Console.Write("\t inter id value:     ");
            string id = Console.ReadLine();
            Console.Write("\t inter name value:     ");
            string name = Console.ReadLine();
            Console.Write("\t inter balance value:     ");
            int balance = int.Parse(Console.ReadLine());
            account my = new account(id, name, balance);
            Console.WriteLine("\n my account:\n id:     {0}\n name:     {1}\n balance:     {2}", my.getid(), my.getname(), my.getbalance());
            Console.WriteLine("\n************ Second account information ************");
            Console.Write("\t inter id value:     ");
            string Id = Console.ReadLine();
            Console.Write("\t inter name value:     ");
            string Name = Console.ReadLine();
            Console.Write("\t inter balance value:     ");
            int Balance = int.Parse(Console.ReadLine());
            account friend = new account(Id, Name, Balance);
            Console.WriteLine("\n friend account:\n id:      {0}\n name:     {1}\n balance:     {2}", friend.getid(), friend.getname(), friend.getbalance());
            int amount = 0;
            int select;
            do
            {
                Console.WriteLine("\t===== Please press the button to make the transaction =====");
                Console.WriteLine("\t 1. Credit ");
                Console.WriteLine("\t 2. Debit ");
                Console.WriteLine("\t 3. Tranfer ");
                Console.WriteLine("\t 0. Return ");
                Console.WriteLine("\t 5. EXIT ");
                select = int.Parse(Console.ReadLine());
                switch (select)
                {
                    case 1:
                        Console.Write("\t inter a mount value to creadit: ");
                        amount = int.Parse(Console.ReadLine());
                        my.credit(amount);
                        Console.Write("\n my account\n id:     {0}\n name:   {1}\n balance:  {2}", my.getid(), my.getname(), my.getbalance());

                        break;
                    case 2:
                        Console.Write("\t inter a mount value to debit: ");
                        amount = int.Parse(Console.ReadLine());
                        my.debit(amount);
                        Console.Write("\n my account\n id:     {0}\n name:   {1}\n balance:  {2}", my.getid(), my.getname(), my.getbalance());

                        break;
                    case 3:
                        Console.Write("\t inter a mount value to tranfer: ");
                        amount = int.Parse(Console.ReadLine());
                        my.tranferto(friend, amount);
                        Console.Write("\n my account\n id:     {0}\n name:   {1}\n balance:  {2}", my.getid(), my.getname(), my.getbalance());
                        Console.Write("____________________________________________");
                        Console.Write("\n friend account\n id:     {0}\n name:   {1}\n balance:  {2}", friend.getid(), friend.getname(), friend.getbalance());
                        break;
                    case 5:
                        goto close;
                }

            } while (select != 5);
        close:;

            Console.ReadKey();
        }
    }
}

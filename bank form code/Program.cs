using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace local_pank_acount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAcount myAcount = new BankAcount("Radwa Banck","phaletien bank","phaletien,gaza,nourth gaza","Ef124358","shecel",1800);
            BankAcount myAcount1 = new BankAcount();
            myAcount1.BankName = "elctronic RADWA Bank";
            myAcount1.BranchName = "egypt branch";
            myAcount1.BranchAdress = "eygpt, assut, new assut city";
            myAcount1.AcountNumber = "Ab010048521";
            myAcount1.AcountCurrency = "L.E";
            myAcount1.Balance = 1500;
            Console.WriteLine(myAcount.BankName);
            Console.WriteLine(myAcount.Balance );
            Console.WriteLine(myAcount1.Balance);
            myAcount.WithDraw(200);
            myAcount.Deposit(250);

            Console.WriteLine();
            Console.ReadLine();
            Console.ReadKey();
        }
    }

    class BankAcount
    {
        public string BankName { get; set; }
        public string BranchName { get; set; }
        public string BranchAdress { get; set; }
        public string AcountNumber { get; set; }
        public string AcountCurrency { get; set; }
        public decimal Balance { get; set; }

        public BankAcount()
        {
            Console.WriteLine("constructor is called automatically ");
        }
        public BankAcount(string BankName, string BranchName, string BranchAdress, string AcountNumber, string AcountCurrency, decimal Balance)
        {
            BankName = BankName;
            BranchName = BranchName;
            BranchAdress = BranchAdress;
            AcountNumber = AcountNumber;
            AcountCurrency = AcountCurrency;
            Balance = Balance;
        }

        public void WithDraw(decimal Amount)
        {
            decimal newBalance = Balance - Amount;
            if (newBalance <0 )
            {
                Console.WriteLine("Invalid transaction ");
            }
            else
            {
                Console.WriteLine($"withdrow amount is {Amount}");
                Console.WriteLine($"Your new balance for acount {AcountNumber} is {newBalance} ");
            }
            Console.WriteLine($"Transaction Date {DateTime.Now}");
        }

        public void Deposit(decimal Amount)
        {
            decimal newBalance = Balance + Amount;
            Console.WriteLine($"Depoit amount is {Amount}");
            Console.WriteLine($"Your new balance for acount {AcountNumber} is {newBalance} ");
            Console.WriteLine($"Transaction Date {DateTime.Now}");
        }

        public void Transfer()
        {

        }

        public void ChangePassword()
        {

        }

        public void CreatSubAcount()
        {

        }

        public void PrintStatement()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banksystem
{
    internal class BankAccount
    {
        //field ใช้เก็บข้อมูลในclass เก็บข้อมูลของบัญชี
        private string accountnumber;
        private string accountholdername;
        private decimal balance;

        //สร้าง consrtuctor ไว้รับข้อมูลมาใช้คือรับเลขบช.ต่างๆมา
        public BankAccount(string accountnumber, string accountholdername, decimal balance)
        {
            this.Accountnumber = accountnumber;
            this.Accountholdername = accountholdername;
            this.Balance = balance;
        }
        //สร้างให้ 3 field นี้เป็น property
        public string Accountnumber { get => accountnumber; set => accountnumber = value; }
        public string Accountholdername { get => accountholdername; set => accountholdername = value; }
        public decimal Balance { get => balance; set => balance = value; }

        //สร้าง method แสดงข้อมูลของแต่ละบช.
        public void showDetailAccount()
        {
            Console.WriteLine("Account Number : " + this.Accountnumber);
            Console.WriteLine("Account Holder Name : " + this.Accountholdername);
            Console.WriteLine("Balance : " + this.Balance.ToString("F2"));
        }

        //สร้าง method สำหรับฝากเงิน
        public void deposit(decimal amount)
        {
            if (amount > 0 && (amount%100)==0)
            {
                Balance = this.Balance + amount;
                Console.WriteLine("Deposit Amount : " + amount.ToString("F2") + " Available Balance : " + Balance.ToString("F2"));
            }
            else
            {
                Console.WriteLine("Invalid amount.  \r\nDeposits must be in denominations of 100, 500, 1000, etc.  \r\nPlease try again");
            }
        }

        //สร้าง method สำหรับถอนเงิน
        public void withdraw(decimal amount)
        {
            if (amount > 0 && Balance>amount && (amount % 100) == 0)
            {
                Balance = Balance - amount;
                Console.WriteLine("Withdrawal Amount : " + amount.ToString("F2") + " Available Balance : " + Balance.ToString("F2"));
            }
            else
            {
                Console.WriteLine("Invalid amount.  \r\nWithdrawals must be in denominations of 100, 200, 500, etc.  \r\nPlease try again.");
            }
            
        }

        //สร้าง method สำหรับโอนเงินระหว่างบช.
        public void transfer(BankAccount toAccount, decimal amount)
        {
            if (amount > 0 && Balance > amount)
            {
                Balance = Balance - amount;
                Console.WriteLine("Transfer Amount : " + amount.ToString("F2") + "  Available Balance : " + Balance.ToString("F2"));
                toAccount.Balance = toAccount.Balance + amount;
                Console.WriteLine("Tranfer to " + toAccount.Accountholdername);
            }
            else
            {
                Console.WriteLine("Transfer failed.  \r\nAn error occurred while processing your transaction.  \r\nPlease try again later.");
            }
        }

       
    }




 
}

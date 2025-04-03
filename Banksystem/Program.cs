// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;
using Banksystem;

Console.WriteLine("######## Welcome to Bank Sysem ########");

//create odject คือวัตถุที่อยู่นในคลาส
BankAccount ac1 = new BankAccount("0200265984123", "Miss Inthira Rueangchatri", 10000); //อันนี้คือบัญชีที่อยู่ในclass บัญชีที่ที่1
BankAccount ac2 = new BankAccount("0214589635458", "Mr.Mark Lee", 50000000); //บช.ที่สอง


bool i = true;
do
{
    Console.WriteLine("########## MENU ##########");
    Console.WriteLine("Enter 1 for Deposit");
    Console.WriteLine("Enter 2 for Withdraw");
    Console.WriteLine("Enter 3 for Transfer");
    Console.WriteLine("Enter 4 for View Account Information");
    Console.Write("Please select an option : ");
    int menu;
    int.TryParse(Console.ReadLine(), out menu);

    switch (menu)
    {
        case 1:
            Console.WriteLine("Deposit");

            //เลขบชที่จะฝากมา
            Console.Write("Please enter your account number : ");
            string accountNumber = Console.ReadLine();
            if (accountNumber == ac1.Accountnumber)
            {
                Console.WriteLine("Your Account Number : " + accountNumber);
                Console.WriteLine("Account Name : " + ac1.Accountholdername);

                //รับจำนวนเงินที่จะทำการฝากเงิน
                decimal money;
                Console.Write("Please enter the amount to deposit : ");
                decimal.TryParse(Console.ReadLine(), out money);
                //ไปเรียกใช้ method ฝากเงิน
                ac1.deposit(money);
            }
            else if (accountNumber == ac2.Accountnumber)
            {
                Console.WriteLine("Your Account Number : " + accountNumber);
                Console.WriteLine("Account Name : " + ac2.Accountholdername);

                //รับจำนวนเงินที่จะทำการฝากเงิน
                decimal money;
                Console.Write("Please enter the amount to deposit : ");
                decimal.TryParse(Console.ReadLine(), out money);
                //ไปเรียกใช้ method ฝากเงิน
                ac2.deposit(money);
            }
            else
            {
                Console.WriteLine("Account not found.  \r\nPlease check your account number and try again.");
            }

            break;
        case 2:
            Console.WriteLine("Withdraw");

            //เลขบชที่จะถอนเงิน
            Console.Write("Please enter your account number : ");
            accountNumber = Console.ReadLine();
            if (accountNumber == ac1.Accountnumber)
            {
                Console.WriteLine("Your Account Number : " + accountNumber);
                Console.WriteLine("Account Name : " + ac1.Accountholdername);

                //รับจำนวนเงินที่จะทำการฝากเงิน
                decimal money;
                Console.Write("Please Enter your money to Withdraw : ");
                decimal.TryParse(Console.ReadLine(), out money);
                //ไปเรียกใช้ method ฝากเงิน
                ac1.withdraw(money);
            }
            else if (accountNumber == ac2.Accountnumber)
            {
                Console.WriteLine("Your Account Number : " + accountNumber);
                Console.WriteLine("Account Name : " + ac2.Accountholdername);

                //รับจำนวนเงินที่จะทำการฝากเงิน
                decimal money;
                Console.Write("Please Enter your money to Withdraw : ");
                decimal.TryParse(Console.ReadLine(), out money);
                //ไปเรียกใช้ method ฝากเงิน
                ac2.withdraw(money);
            }
            else
            {
                Console.WriteLine("Account not found.  \r\nPlease check your account number and try again.");
            }
            break;
        case 3:
            Console.WriteLine("Transfer");

            //เลขบชที่จะโอนเงิน
            Console.Write("Please enter your account number : ");
            accountNumber = Console.ReadLine();
            if (accountNumber == ac1.Accountnumber)
            {
                Console.WriteLine("Your Account Number : " + accountNumber);
                Console.WriteLine("Account Name : " + ac1.Accountholdername);

                //เก็บเลขบช.ที่ต้องการโอน
                BankAccount numTrans = null;
                Console.Write("Please enter the account number to transfer to : ");
                string accountTransfer = Console.ReadLine();
                if (accountTransfer == ac1.Accountnumber && accountTransfer != accountNumber)
                {
                    numTrans = ac1;
                    Console.WriteLine("Account name : " + ac1.Accountholdername);
                }
                else if (accountTransfer == ac2.Accountnumber && accountTransfer != accountNumber)
                {
                    numTrans = ac2;
                    Console.WriteLine("Account name : " + ac2.Accountholdername);
                }
                else
                {
                    Console.WriteLine("Account not found.  \r\nPlease check the recipient's account number and try again. ");
                    break;
                }

                //รับจำนวนเงินที่จะทำการโอน
                decimal money;
                Console.Write("Please enter the amount to transfer : ");
                decimal.TryParse(Console.ReadLine(), out money);
                //ไปเรียกใช้ method โอนเงิน
                ac1.transfer(numTrans, money);
            }
            else if (accountNumber == ac2.Accountnumber)
            {
                Console.WriteLine("Your Account Number : " + accountNumber);
                Console.WriteLine("Account Name : " + ac2.Accountholdername);

                //เก็บเลขบช.ที่จะโอน
                BankAccount numTrans = null;
                Console.Write("Please enter the account number to transfer to : ");
                string accountTransfer = Console.ReadLine();
                if (accountTransfer == ac1.Accountnumber && accountTransfer != accountNumber)
                {
                    numTrans = ac1;
                    Console.WriteLine("Account name : " + ac1.Accountholdername);
                }
                else if (accountTransfer == ac2.Accountnumber && accountTransfer != accountNumber  )
                {
                    numTrans = ac2;
                    Console.WriteLine("Account name : " + ac2.Accountholdername);
                }
                else
                {
                    Console.WriteLine("Account not found.  \r\nPlease check the recipient's account number and try again. ");
                }

                //รับจำนวนเงินที่จะทำการโอนเงิน
                decimal money;
                Console.Write("Please enter the amount to transfer : ");
                decimal.TryParse(Console.ReadLine(), out money);
                //ไปเรียกใช้ method โอนงิน
                ac2.transfer(numTrans, money);
            }
            else
            {
                Console.WriteLine("Account not found.  \r\nPlease check your account number and try again.");
            }
            break;
        case 4:
            {
                Console.WriteLine("Show Account Information");

                //เลขบชที่จะดูข้อมูล
                Console.Write("Please enter your account number : ");
                accountNumber = Console.ReadLine();
                if (accountNumber == ac1.Accountnumber)
                {
                    Console.WriteLine("Account found");
                    ac1.showDetailAccount(); //โชว์ข้อมูล
                }
                else if (accountNumber == ac2.Accountnumber)
                {
                    Console.WriteLine("Account found");
                    ac2.showDetailAccount();
                }
                else
                {
                    Console.WriteLine("Account not found.  \r\nPlease check your account number and try again.");
                }
                break;
            }
        default:
            Console.WriteLine("Invalid menu selection.");
            break;
    }
}
while (i);

Console.ReadKey();
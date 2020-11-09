using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {

            //Bank account

            var account = new BankAccount();

            Console.WriteLine("How much would you like to deposit?");

            var amountToDeposit = double.Parse(Console.ReadLine());
            account.Deposit(amountToDeposit);

            Console.WriteLine($"Thank you! Your balance is now {account.GetBalance()}");

            //Phone number

            var accountInfo = new PersonalInformation();
            string number;
            long result;

            do
            {
                Console.WriteLine("What is your phone number starting with the area code?");
                Console.WriteLine("With the following format: 8171231234");
                number = Console.ReadLine();

            } while (number.Length != 10 || !long.TryParse(number, out result));

            accountInfo.NumberFormatted = number;
            Console.WriteLine(accountInfo.NumberFormatted);


            // Console.WriteLine($" {accountInfo.NumberFormatted}");


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            InternetBankingInterface savingAccount = new SavingAccount();
            InternetBankingInterface currentAccount = new CurrentAccount();

            savingAccount.Deposit(1000);
            savingAccount.Withdraw(800);
            savingAccount.GetBalance();

            currentAccount.Deposit(1000);
            currentAccount.Withdraw(800);
            currentAccount.Withdraw(300);
            currentAccount.GetBalance();

            Console.ReadKey();
        }
    }
    interface InternetBankingInterface
    {
        bool Deposit(decimal amount);
        bool Withdraw(decimal amount);
        void GetBalance();
    }

    public class SavingAccount : InternetBankingInterface
    {
        private decimal _balance;
        private decimal _perDayLimit;

        public bool Deposit(decimal amount)
        {
            _balance += amount;
            return true;
        }

        public void GetBalance()
        {
            Console.WriteLine("Saving Account Balance = {0}", _balance);
        }

        public void Withdraw()
        {
            throw new NotImplementedException(); 
        }

        public bool Withdraw(decimal amount)
        {
            if (_balance < amount)
            {
                Console.WriteLine("Insufficient balance");
                return false;
            }
            else if (_perDayLimit + amount > 5000)  // limit is 5000
            {
                Console.WriteLine("Withdraw attempt failed");
                return false;
            }

            else
            {
                _balance -= amount;
                _perDayLimit += amount;
                Console.WriteLine(String.Format("Successfully withdraw: {0}", amount));
                return true;
            }
        }
    }

    public class CurrentAccount : InternetBankingInterface
    {
        private decimal _balance;

        public bool Deposit(decimal amount)
        {
            _balance += amount;
            return true;
        }

        public void GetBalance()
        {
            Console.WriteLine("Current Account Balance = {0}", _balance);
        }

        public bool Withdraw(decimal amount)
        {
            if (_balance < amount)
            {
                Console.WriteLine("Insufficient balance");
                return false;
            }

            else
            {
                _balance -= amount;
                Console.WriteLine(String.Format("Successfully withdraw: {0}", amount));
                return true;
            }
        }
    }
}

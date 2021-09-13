using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingsAcc savings = new SavingsAcc(1000.0);
            if (savings.Deposit(1000))
            {
                Console.WriteLine("Deposit Successful");
            }
            else
            {
                Console.WriteLine("Transaction unsuccessful");
            }
            if (savings.Withdraw(800))
            {
                Console.WriteLine("Withdrawal successful");
            }
            else
            {
                Console.WriteLine("Transaction unsuccessful");
            }
            Console.ReadKey();
            
        }
    }
    abstract class Bank
    {
        public virtual Boolean Deposit(double amt)
        {
            if (this.Balance > amt)
            {
                this.Balance -= amt;
                return true;
            }
            else
            {
                return false;
            }
        }
        public abstract Boolean Withdraw(double amt);
        protected double Balance = 0.0;
        protected void viewBalance()
        {
            Console.WriteLine("{0}", this.Balance);
        }
    }
    class SavingsAcc : Bank
    {
        public SavingsAcc(double Balance)
        {
            this.Balance = Balance; 
        }
        public override Boolean Withdraw(double withdrawAmt)
        {
            if (this.Balance > withdrawAmt)
            {
                Balance -= withdrawAmt;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

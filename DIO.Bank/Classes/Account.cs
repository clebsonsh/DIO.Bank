using System;

namespace DIO.Bank
{
	public class Account
	{
		//Attributes
		private string Customer { get; set; }
		private double Balance { get; set; }

		// Constructor
		public Account(string customer, double balance)
		{
			this.Customer = customer;
			this.Balance = balance;
		}

		// Methods
    public void Deposit(double amountToDeposit)
    {
      this.Balance += amountToDeposit;

      Console.WriteLine("{0}'s Account current balance: {1}", this.Customer, this.Balance);
    }

		public bool Withdraw(double amountToWithdraw)
		{
			if (this.Balance - amountToWithdraw < 0)
			{
				Console.WriteLine("Not enought balance to withdraw...");
        return false;
			}

      this.Balance -= amountToWithdraw;

      Console.WriteLine("{0}'s Account current balance: {1}", this.Customer, this.Balance);

      return true;
		}

    public void Transfer(double amountToTransfer, Account destinationAccount)
    {
      if (this.Withdraw(amountToTransfer))
      {
        destinationAccount.Deposit(amountToTransfer);
      }
    }

		public override string ToString()
		{
			string accountString = "Customer Name: " + this.Customer + " | ";
			accountString += "Balance: " + this.Balance;
			return accountString;
		}
	}
}

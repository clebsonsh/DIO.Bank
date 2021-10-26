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
		public bool Withdraw(double amountToWithdraw)
		{
			if (this.Balance - amountToWithdraw < 0)
			{
				Console.WriteLine("Not enought balance to withdraw...");
			}

      this.Balance -= amountToWithdraw;

      Console.WriteLine("Account current balance: {0}", this.Balance);

      return true;
		}

		public override string ToString()
		{
			string accountString = "Customer Name: " + this.Customer + " | ";
			accountString += "Balance: " + this.Balance;
			return accountString;
		}
	}
}

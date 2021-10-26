using System;
using System.Collections.Generic;

namespace DIO.Bank
{
  class Program
  {
    static List<Account> accountsList = new List<Account>();
    
    static void Main(string[] args)
    {
      string userChoice = GetUserChoice();

      while (userChoice != "X")
      {

        Console.Clear();
        switch (userChoice)
        {
          case "1":
            ShowAllAccounts();
            break;
          case "2":
            MakeNewAccount();
            break;
          case "3":
            Deposit();
            break;
          case "4":
            Withdraw();
            break;
          case "5":
            Transfer();
            break;
          default:
            Console.WriteLine("Please select a valid option...");
            break;
        }

        userChoice = GetUserChoice();
      }
      Console.WriteLine("We are happy to have you was a customer");
      Console.WriteLine("Come back later\n");
    }

		private static void ShowAllAccounts()
		{
      if (accountsList.Count == 0)
      {
        Console.WriteLine("There is no account in the system yet...");
        return;
      }

      for (int i = 0; i < accountsList.Count; i++)
      {
        Account account = accountsList[i];
        Console.WriteLine("#{0} - {1}", i, account);
      }
		}

		private static void MakeNewAccount()
		{
      Console.WriteLine("Let's make a new account..");

      Console.Write("Customer Customer: ");
      string customer = Console.ReadLine();

      Console.Write("Initial Balance: ");
      double balance = double.Parse(Console.ReadLine());

      Account newAccount = new Account(customer: customer, balance: balance);

      accountsList.Add(newAccount);
		}

		private static void Deposit()
		{
      Console.Write("Enter account number to deposit: ");
      int accountIndex = int.Parse(Console.ReadLine());

      Console.Write("Enter amount to deposit: ");
      double amountToDeposit = double.Parse(Console.ReadLine());

      accountsList[accountIndex].Deposit(amountToDeposit);
		}

		private static void Withdraw()
		{
      Console.Write("Enter account number to withdraw: ");
      int accountIndex = int.Parse(Console.ReadLine());

      Console.Write("Enter amount to withdraw: ");
      double amountToWithdraw = double.Parse(Console.ReadLine());

      accountsList[accountIndex].Withdraw(amountToWithdraw);
		}

		private static void Transfer()
		{
      Console.Write("Enter account number that is sending money: ");
      int indexSendingAccount = int.Parse(Console.ReadLine());

      Console.Write("Enter account number that is receiving money: ");
      int indexReceivingAccount = int.Parse(Console.ReadLine());

      Console.Write("Enter amount to transfer: ");
      double amountToTransfer = double.Parse(Console.ReadLine());

      accountsList[indexSendingAccount]
          .Transfer(amountToTransfer, accountsList[indexReceivingAccount]);
		}

		private static string GetUserChoice()
    {
      Console.Write(@"
      ##############################
      Welcome to DIO Bank!

      1 - Show all accounts
      2 - Make a new account
      3 - Deposit
      4 - Withdraw
      5 - Transfer
      X - Quit

      ##############################

      Please select a option: ");

      string userChoice = Console.ReadLine().ToUpper();
      Console.WriteLine();
      return userChoice;
    }
  }
}

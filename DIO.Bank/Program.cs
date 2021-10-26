﻿using System;
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
            Console.WriteLine("Please select a valid opton...");
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
			throw new NotImplementedException();
		}

		private static void Deposit()
		{
			throw new NotImplementedException();
		}

		private static void Withdraw()
		{
			throw new NotImplementedException();
		}

		private static void Transfer()
		{
			throw new NotImplementedException();
		}

		private static string GetUserChoice()
    {
      Console.WriteLine(@"
      ##############################
      Welcome to DIO Bank!
      Please select a option:

      1 - Show all accounts
      2 - Make a new account
      3 - Deposit
      4 - Withdraw
      5 - Transfer
      X - Quit

      ##############################
      ");

      string userChoice = Console.ReadLine().ToUpper();
      Console.WriteLine();
      return userChoice;
    }
  }
}

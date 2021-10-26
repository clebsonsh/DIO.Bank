using System;

namespace DIO.Bank
{
  class Program
  {
    static void Main(string[] args)
    {
      string userChoice = GetUserChoice();
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
      C - Clean screen
      X - Quit

      ##############################
      ");

      string userChoice = Console.ReadLine().ToUpper();
      return userChoice;
    }
  }
}

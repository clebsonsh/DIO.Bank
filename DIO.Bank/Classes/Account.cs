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
        // To do...

        public override string ToString()
        {
            string accountString  = "Customer Name: " + this.Customer + " | ";
            accountString += "Balance: " + this.Balance;
            return accountString;
        }
    }
}

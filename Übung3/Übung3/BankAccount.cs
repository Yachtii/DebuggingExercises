class BankAccount
{
    private string owner;
    private double balance;

    public BankAccount(string owner, double balance)
    {
        owner = owner;             // Bug 1: owner is never stored in the field
        this.balance = balance;
    }

    public void Deposit(double amount)
    {
        balance -= amount;         // Bug 2: wrong operator
    }

    public void Withdraw(double amount)
    {
        if (amount > balance)
        {
            Console.WriteLine("Insufficient funds!");
            return;
        }
        balance -= amount;
    }

    public bool IsOverdrawn()
    {
        return balance > 0;        // Bug 3: wrong comparison direction
    }

    public double CalculateInterest(double ratePercent)
    {
        return balance * ratePercent;  // Bug 4: rate is a percentage, not a decimal
    }

    public string GetInfo()
    {
        return $"Owner: {owner}, Balance: {balance:F2}€";
    }
}

// Debugging Exercise: BankAccount
// This program contains 4 bugs. Find and fix all of them!
// Expected output is shown at the bottom as comments.

BankAccount account = new BankAccount("Max Mustermann", 1000.0);

Console.WriteLine("=== Bank Account Info ===");
Console.WriteLine(account.GetInfo());

account.Deposit(500.0);
Console.WriteLine("\nAfter depositing 500€:");
Console.WriteLine(account.GetInfo());

account.Withdraw(200.0);
Console.WriteLine("\nAfter withdrawing 200€:");
Console.WriteLine(account.GetInfo());

Console.WriteLine($"\nIs the account overdrawn? {account.IsOverdrawn()}");

double interest = account.CalculateInterest(5.0);
Console.WriteLine($"Interest at 5%: {interest:F2}€");

// === Expected Output ===
// Owner: Max Mustermann, Balance: 1000.00€
//
// After depositing 500€:
// Owner: Max Mustermann, Balance: 1500.00€
//
// After withdrawing 200€:
// Owner: Max Mustermann, Balance: 1300.00€
//
// Is the account overdrawn? False
// Interest at 5%: 65.00€

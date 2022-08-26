namespace BankAPI.Models;

public class Account
{
    public decimal Balance { get; private set; } = 100;

    public Account(int startBalance)
    {
        Balance = startBalance;
    }

    public bool Withdraw (decimal amount)
    {
        var result = false;
        if (amount <= Balance && amount >= 0)
        {
            Balance -= amount;
            result = true;
        }
        return result;
    }

    public bool Insert(decimal amount)
    {
        return true;
    }
}

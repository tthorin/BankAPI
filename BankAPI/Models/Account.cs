namespace BankAPI.Models;

public class Account
{
    public decimal Balance { get; private set; }

    public Account(decimal startBalance)
    {
        if (startBalance < 0) startBalance = 0;
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
        var result = false;
        if (amount >= 0)
        {
            Balance += amount;
            result = true;
        }
        return result;
    }
}

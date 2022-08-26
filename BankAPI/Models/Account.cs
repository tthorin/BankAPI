namespace BankAPI.Models;

public class Account
{
    public decimal Balance { get; private set; }

    public Account(decimal startBalance)
    {
        if (startBalance < 0) startBalance = 0;
        Balance = startBalance;
    }

    public BankResponse Withdraw (decimal amount)
    {
        var result = false;
        if (amount <= Balance && amount >= 0)
        {
            Balance -= amount;
            result = true;
        }
        return new BankResponse { success=result,newBalance=Balance };
    }

    public BankResponse Insert(decimal amount)
    {
        var result = false;
        if (amount >= 0)
        {
            Balance += amount;
            result = true;
        }
        return new BankResponse { success=result,newBalance=Balance};
    }
    public decimal GetBalance()
    {
        return Balance;
    }
}

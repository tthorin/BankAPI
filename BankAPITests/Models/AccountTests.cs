using Xunit;
using BankAPI.Models;

namespace BankAPI.Models.Tests;

public class AccountTests
{
    readonly Account sut = new(100);

    [Fact()]
    public void WithdrawLessThanBalanceShouldReturnTrue()
    {
        var expected = true;
        var result = sut.Withdraw(50);

        Assert.Equal(expected, result);
    }
    [Fact()]
    public void WithdrawMoreThanBalanceShouldReturnFalse()
    {
        var expected = false;
        var result = sut.Withdraw(150);

        Assert.Equal(expected, result);
    }
    [Fact()]
    public void WithdrawNegativeNumberShouldReturnFalse()
    {
        var expected = false;
        var result = sut.Withdraw(-150M);

        Assert.Equal(expected, result);
    }
    [Fact()]
    public void InsertPositiveNumberShouldReturnTrue()
    {
        var expected = true;
        var result = sut.Insert(150M);

        Assert.Equal(expected, result);
    }
    [Fact()]
    public void InsertNegativeNumberShouldReturnFalse()
    {
        var expected = false;
        var result = sut.Insert(-150M);
    }
}
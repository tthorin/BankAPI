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
        var expectedBalance = 49.5M;
        var result = sut.Withdraw(50.5M);

        Assert.Equal(expected, result.success);
        Assert.Equal(expectedBalance, result.newBalance);
    }
    [Fact()]
    public void WithdrawMoreThanBalanceShouldReturnFalse()
    {
        var expected = false;
        var expectedBalance = 100M;
        var result = sut.Withdraw(150M);

        Assert.Equal(expected, result.success);
        Assert.Equal(expectedBalance, result.newBalance);
    }
    [Fact()]
    public void WithdrawNegativeNumberShouldReturnFalse()
    {
        var expected = false;
        var expectedBalance = 100M;
        var result = sut.Withdraw(-50M);

        Assert.Equal(expected, result.success);
        Assert.Equal(expectedBalance, result.newBalance);
    }
    [Fact()]
    public void InsertPositiveNumberShouldReturnTrue()
    {
        var expected = true;
        var expectedBalance = 150.5M;
        var result = sut.Insert(50.5M);

        Assert.Equal(expected, result.success);
        Assert.Equal(expectedBalance, sut.Balance);
    }
    [Fact()]
    public void InsertNegativeNumberShouldReturnFalse()
    {
        var expected = false;
        var expectedBalance = 100M;
        var result = sut.Insert(-50.5M);

        Assert.Equal(expected, result.success);
        Assert.Equal(expectedBalance, result.newBalance);
    }
}
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BankAPI.Controllers;

using BankAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

[Route("[controller]")]
[ApiController]
public class BankController : ControllerBase
{
    private Account account;
    public BankController(Account acc)
    {
        this.account = acc;
    }
    // GET: api/<BankController>
    [HttpGet]
    public string Get()
    {
        var result = new BankResponse { success = true, newBalance = account.Balance };
        var json = JsonConvert.SerializeObject(result);
        return json;
    }

    // PUT api/<BankController>/5
    [HttpPut("withdraw/{amount}")]
    public string Withdraw(decimal amount)
    {
        var result = account.Withdraw(amount);
        var json = JsonConvert.SerializeObject(result);
        return json;
    }
    [HttpPut("insert/{amount}")]
    public string Insert(decimal amount)
    {
        var result = account.Insert(amount);
        var json = JsonConvert.SerializeObject(result);
        return json;
    }

    
}

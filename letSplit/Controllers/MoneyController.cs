using letSplit.AppDbContext;
using letSplit.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Web.Resource;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace letSplit.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class MoneyController : ControllerBase
{
    private readonly AplDbContext _db;
    public MoneyController(AplDbContext db)
    {
        _db = db;
    }
    
    [HttpPost]
    public MyEvent CreateEvent(MyEvent myEventModel)
    {
        _db.MyEvents.Add(myEventModel);
        return myEventModel;
    }
    [HttpGet]
    public MyEvent GetEvent(string eventName)
    {
        return _db.MyEvents.FirstOrDefault(e => e.EventName == eventName) ?? throw new InvalidOperationException();
    }
    
    [HttpGet]
    public List<MyEvent> GetEvents()
    {
        return _db.MyEvents.Include(e => e.Users).Include(u => u.Spends).ToList();
    }

    [HttpGet]
    public IList<User> GetParticipants(string eventName)
    {
        if (string.IsNullOrWhiteSpace(eventName))
        {
            return new List<User>();
        }
        
        var users = _db.MyEvents.FirstOrDefault(e => e.EventName == eventName).Users.ToList();
        return users;
    }
}
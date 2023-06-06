using letSplit.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web.Resource;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace letSplit.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class MoneyController : ControllerBase
{
    public static ICollection<MyEvent> _events;
    public MoneyController()
    {
        _events = new List<MyEvent>();
        var newEvent = new MyEvent ()
        {
            EventName = "Let's Split",
            // Participants = new List<Participant>()
            // {
            //     new Participant() {Name = "John", Email = "j@j.com"},
            // },
            // EventCurrency = Currency.RUB,
        };
        // _events = new List<MyEvent>()
        // {
        //     new MyEvent()
        //     {
        //         EventName = "Let's Split",
        //         // Participants = new List<Participant>()
        //         // {
        //         //     new Participant() { Name = "John", Email = "j@j.com" }
        //         // },
        //         // EventCurrency = Currency.RUB,
        //     },
        //     new MyEvent()
        //     {
        //         EventName = "Another Event",
        //         // Participants = new List<Participant>()
        //         // {
        //         //     new Participant() { Name = "Alice", Email = "a@a.com" }
        //         // },
        //         // EventCurrency = Currency.USD,
        //     }
        // };
        _events.Add(newEvent);
    }
    
    [HttpPost]
    public MyEvent CreateEvent(MyEvent myEventModel)
    {
        _events.Add(myEventModel);
        return myEventModel;
    }
    [HttpGet]
    public MyEvent GetEvent(string eventName)
    {
        return _events.FirstOrDefault(e => e.EventName == eventName) ?? throw new InvalidOperationException();
    }
    
    [HttpGet]
    public MyEvent GetEvents()
    {
        return _events.FirstOrDefault();

    }

    // [HttpGet]
    // public IList<Participant> GetParticipants(string eventName)
    // {
    //     if (string.IsNullOrWhiteSpace(eventName))
    //     {
    //         return new List<Participant>();
    //     }
    //     
    //     var users = _events.FirstOrDefault(e => e.EventName == eventName).Participants.ToList();
    //     return users;
    // }
}
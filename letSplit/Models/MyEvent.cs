using System.Text.Json.Serialization;

namespace letSplit.Models;

public class MyEvent
{
    public MyEvent()
    {
        
    }
    public string EventName = "String.Empty";
    
    [JsonPropertyName("eventCurrency")]
    public Currency EventCurrency = Currency.RUB;
    
    [JsonPropertyName("participants")]
    public IEnumerable<User> Participants;
    
    [JsonPropertyName("spends")]
    public IEnumerable<Spend>? Spends;
}
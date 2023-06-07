using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore.Metadata;

namespace letSplit.Models;

public class MyEvent
{
    public MyEvent()
    {
        
    }
    [Key]
    public long Id { get; set; }
    
    [JsonPropertyName("eventName")]
    public string EventName { get; set; } = string.Empty;

    [JsonPropertyName("eventCurrency")]
    public Currency EventCurrency { get; set; } = Currency.RUB;

    [JsonPropertyName("users")]
    public ICollection<User> Users { get; set; }
    
    [JsonPropertyName("spends")]
    public ICollection<Spend>? Spends { get; set; }
}
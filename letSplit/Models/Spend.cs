using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace letSplit.Models;

public class Spend
{
    public Spend()
    {
        
    }
    [Key]
    public long Id { get; set; }
    
    public string? SpendName { get; set; }
    
    public double? SpendAmount { get; set; }
    
    public DateTime? Date { get; set; }
    
    public string? Description { get; set; }
    
    public long MyEventId { get; set; } // Внешний ключ
    
    [ForeignKey("MyEventId")]
    public virtual MyEvent MyEvent { get; set; } // Навигационное свойство
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace letSplit.Models;

public class User
{
    public User()
    {
        
    }
    [Key]
    public long Id { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    
    public long MyEventId { get; set; } // Внешний ключ
    
    [ForeignKey("MyEventId")]
    public virtual MyEvent MyEvent { get; set; } // Навигационное свойство
}
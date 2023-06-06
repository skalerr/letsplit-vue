using letSplit.Models;
using Microsoft.EntityFrameworkCore;

namespace letSplit.AppDbContext;

public class AppDbContext : DbContext
{
    public AppDbContext()
    {
        Database.EnsureDeleted();
        Database.EnsureCreated();
        
    }
    public DbSet<MyEvent> MyEvents { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Spend> Spends { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MyEvent>().HasData(
            new MyEvent()
            {
                EventName = "Let's Split",
                Participants = new List<User>()
                {
                    new User() {Name = "John", Email = "j@j.com"},
                },
                EventCurrency = Currency.RUB,
            },
            
            new MyEvent()
            {
                EventName = "Test1",
                Participants = new List<User>()
                {
                    new User(){Name = "Name", Email = "Email" },
                    new User(){Name = "Name", Email = "Email" },
                },
                EventCurrency = Currency.RUB
            }
        );
    }
}
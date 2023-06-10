using letSplit.Models;
using Microsoft.EntityFrameworkCore;

namespace letSplit.AppDbContext;

public class AplDbContext : DbContext
{
    public AplDbContext(DbContextOptions<AplDbContext> options) : base(options)
    {
        Database.EnsureDeleted();
        Database.EnsureCreated();

    }

    public DbSet<MyEvent> MyEvents { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Spend> Spends { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // modelBuilder.Entity<User>()
        //     .HasOne(u => u.MyEvent)
        //     .WithMany(e => e.Users)
        //     .HasForeignKey(u => u.MyEventId);
        
        modelBuilder.Entity<MyEvent>().HasData(
            new MyEvent()
            {
                Id = 1,
                EventName = "Let's Split",
                EventCurrency = Currency.RUB,
            }
        );
        
        modelBuilder.Entity<User>().HasData(
            new User { Id = 1, Name = "John", Email = "j@j.com", MyEventId = 1},
            new User { Id = 2, Name = "Mary",Email = "u@u.com", MyEventId = 1 },
            new User { Id = 3, Name = "Stephan", Email = "s@s.com", MyEventId = 1 }
        );
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase("YourDatabaseName");
    }
}
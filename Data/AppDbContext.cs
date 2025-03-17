using GraphQLPostgresDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQLPostgresDemo.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Account> Accounts { get; set; }
    public DbSet<AccountBalance> AccountBalances { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>()
            .HasMany(a => a.Balances)
            .WithOne(b => b.Account)
            .HasForeignKey(b => b.AccountId);
    }
}

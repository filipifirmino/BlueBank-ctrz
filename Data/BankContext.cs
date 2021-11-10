using BlueBank.Domain.Core;
using BlueBank.Infra.Data.Configs;
using Microsoft.EntityFrameworkCore;

namespace BlueBank.Domain.Data
{
    public class BankContext : DbContext
    {
        public BankContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           new ClientConfig().Configure(modelBuilder.Entity<Client>());
           new AccountConfig().Configure(modelBuilder.Entity<Account>());
           new TransactionConfig().Configure(modelBuilder.Entity<Transaction>());

        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }
}

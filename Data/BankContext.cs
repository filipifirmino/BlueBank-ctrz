
using BlueBanck.Data.Configs;
using BlueBank.Domain.Core;
using BlueBank.Domain.Data.Configs;
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
           new ClientRelationshipConfig().Configure(modelBuilder.Entity<Client>());
          // new AccountRelationshipConfig().Configure(modelBuilder.Entity<Account>());
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Account> Accounts { get; set; }
    }
}

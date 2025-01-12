using Bank.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Bank.Api.Data
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Account> Accounts { get; set; }

    }
}

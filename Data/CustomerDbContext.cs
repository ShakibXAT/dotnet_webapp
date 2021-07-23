using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Data
{
    public class CustomerDbContext: DbContext
    {
        public CustomerDbContext(DbContextOptions options)
        : base(options)
        {
            
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
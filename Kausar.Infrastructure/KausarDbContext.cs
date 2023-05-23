using Kausar.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace Kausar.Infrastructure
{
    public class KausarDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerAddress> CustomerAddresses { get; set; }
        public DbSet<CustomerIdentification> CustomerIdentifications { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}

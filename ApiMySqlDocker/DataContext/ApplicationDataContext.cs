using ApiMySqlDocker.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiMySqlDocker.DataContext
{
    public class ApplicationDataContext : DbContext
    {
        public ApplicationDataContext(DbContextOptions<ApplicationDataContext> options) : base(options)
        {
            this.Database.EnsureCreated();
        }

        public DbSet<Product> Products { get; set; }
    }
}

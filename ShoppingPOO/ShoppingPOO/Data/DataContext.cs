
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ShoppingPOO.Data.Entities;

namespace ShoppingPOO.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) //metodo antes de crear la BD
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasIndex(c => c.Name).IsUnique();
        }
    }
}

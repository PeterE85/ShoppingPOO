
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

        public DbSet<City> Cities { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<State> States { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) //metodo antes de crear la BD
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasIndex(c => c.Name).IsUnique();
            modelBuilder.Entity<Category>().HasIndex(c => c.Name).IsUnique();
            modelBuilder.Entity<State>().HasIndex("Name", "CountryId").IsUnique(); //Indice compuesto //un solo estado con el mismo nombre en un pais
            modelBuilder.Entity<City>().HasIndex("Name", "StateId").IsUnique(); //Indice compuesto //una sola ciudad con el mismo nombre en un estado
        }
    }
}

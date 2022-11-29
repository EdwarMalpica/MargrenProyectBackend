using Margren.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Margren.Infrastructure
{
    public class DataBaseContext:DbContext
    {

        public DataBaseContext(DbContextOptions<DataBaseContext> options):base(options)
        {
                
        }
        public DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>(o =>
            {
                o.HasKey(x=> x.Id);
            });
            modelBuilder.Entity<Person>().OwnsOne(o=>o.Name, conf=>
                {
                    conf.Property(x => x.Value).HasColumnName("Name");
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
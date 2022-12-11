using Margren.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Margren.Infrastructure
{
    public class DataBaseContext:DbContext
    {

        public DataBaseContext(DbContextOptions<DataBaseContext> options):base(options)
        {
                
        }
        public DbSet<Person> PERSONAS { get; set; }
        public DbSet<User> USERS { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //PERSONAS
            modelBuilder.Entity<Person>(o =>
            {
                o.HasKey(x=> x.id_person);
            });

            modelBuilder.Entity<Person>().OwnsOne(o=>o.first_name, conf=>
                {
                    conf.Property(x => x.Value).HasColumnName("first_name");
            });

            modelBuilder.Entity<Person>().OwnsOne(o => o.last_name, conf =>
            {
                conf.Property(x => x.Value).HasColumnName("last_name");
            });
            modelBuilder.Entity<Person>().OwnsOne(o => o.gender, conf =>
            {
                conf.Property(x => x.value).HasColumnName("gender");
            });
            modelBuilder.Entity<Person>().OwnsOne(o => o.type_document, conf =>
            {
                conf.Property(x => x.value).HasColumnName("type_document");
            });
            modelBuilder.Entity<Person>().OwnsOne(o => o.num_document, conf =>
            {
                conf.Property(x => x.value).HasColumnName("num_document");
            });

            //USERS
            modelBuilder.Entity<User>(o =>
            {
                o.HasKey(x => x.id_user);
            });
            modelBuilder.Entity<User>().OwnsOne(o => o.email, conf =>
            {
                conf.Property(x => x.value).HasColumnName("email");
            });
            modelBuilder.Entity<User>().OwnsOne(o => o.rol_name, conf =>
            {
                conf.Property(x => x.value).HasColumnName("rol_name");
            });
            modelBuilder.Entity<User>().OwnsOne(o => o.id_person, conf =>
            {
                conf.Property(x => x.value).HasColumnName("id_person");
            });
            modelBuilder.Entity<User>().OwnsOne(o => o.password, conf =>
            {
                conf.Property(x => x.value).HasColumnName("password");
            });



            base.OnModelCreating(modelBuilder);
        }
    }
}
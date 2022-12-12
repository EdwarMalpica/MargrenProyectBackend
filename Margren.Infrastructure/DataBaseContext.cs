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
        public DbSet<Address> DIRECCIONES { get; set; }
        public DbSet<Coordinate> COORDENADAS { get; set; }
        public DbSet<Ingredient> INGREDIENTES { get; set; }
        public DbSet<Inventory> INVENTARIOS { get; set; }
        public DbSet<Prescription> RECETAS { get; set; }
        public DbSet<Step> PASOS { get; set; }
        public DbSet<Product> PRODUCTOS { get; set; }
        public DbSet<Buy> COMPRAS { get; set; }
        public DbSet<Place> LUGARES { get; set; }
        public DbSet<RegisterInventory> REGISTROS_INVENTARIOS { get; set; }
        public DbSet<RLShop> REGISTROS_L_COMPRAS { get; set; }
        public DbSet<ShopList> LISTAS_DE_COMPRAS { get; set; }

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

            //ADDRESS
            modelBuilder.Entity<Address>(o =>
            {
                o.HasKey(x => x.id_address);
            });
            modelBuilder.Entity<Address>().OwnsOne(o => o.kind_of_street, conf =>
            {
                conf.Property(x => x.value).HasColumnName("kind_of_street");
            });
            modelBuilder.Entity<Address>().OwnsOne(o => o.number_street, conf =>
            {
                conf.Property(x => x.value).HasColumnName("number_street");
            });
            modelBuilder.Entity<Address>().OwnsOne(o => o.num_one, conf =>
            {
                conf.Property(x => x.value).HasColumnName("num_one");
            });
            modelBuilder.Entity<Address>().OwnsOne(o => o.num_two, conf =>
            {
                conf.Property(x => x.value).HasColumnName("num_two");
            });
            modelBuilder.Entity<Address>().OwnsOne(o => o.description, conf =>
            {
                conf.Property(x => x.value).HasColumnName("description");
            });
            modelBuilder.Entity<Address>().OwnsOne(o => o.id_person, conf =>
            {
                conf.Property(x => x.value).HasColumnName("id_person");
            });
            modelBuilder.Entity<Address>().OwnsOne(o => o.id_lugar, conf =>
            {
                conf.Property(x => x.value).HasColumnName("id_lugar");
            });

            //COMPRAS
            modelBuilder.Entity<Buy>(o =>
            {
                o.HasKey(x => x.id_shop);
            });
            modelBuilder.Entity<Buy>().OwnsOne(o => o.id_shopList, conf =>
            {
                conf.Property(x => x.value).HasColumnName("id_shopList");
            });
            modelBuilder.Entity<Buy>().OwnsOne(o => o.id_user, conf =>
            {
                conf.Property(x => x.value).HasColumnName("id_user");
            });
            //COORDENADAS
            modelBuilder.Entity<Coordinate>(o =>
            {
                o.HasKey(x => x.id_address);
            });
            modelBuilder.Entity<Coordinate>().OwnsOne(o => o.latitude, conf =>
            {
                conf.Property(x => x.value).HasColumnName("latitude");
            });
            modelBuilder.Entity<Coordinate>().OwnsOne(o => o.lenght, conf =>
            {
                conf.Property(x => x.value).HasColumnName("lenght");
            });

            //INGREDIENTES
            modelBuilder.Entity<Ingredient>(o =>
            {
                o.HasKey(x=> x.id_ingredient);
            });

            modelBuilder.Entity<Ingredient>().OwnsOne(o => o.id_product, conf =>
            {
                conf.Property(x => x.value).HasColumnName("id_product");
            });
            modelBuilder.Entity<Ingredient>().OwnsOne(o => o.id_prescription, conf =>
            {
                conf.Property(x => x.value).HasColumnName("id_prescription");
            });
            modelBuilder.Entity<Ingredient>().OwnsOne(o => o.amount, conf =>
            {
                conf.Property(x => x.value).HasColumnName("amount");
            });
            modelBuilder.Entity<Ingredient>().OwnsOne(o => o.units, conf =>
            {
                conf.Property(x => x.value).HasColumnName("units");
            });


            //LUGARES
            modelBuilder.Entity<Place>(o =>
            {
                o.HasKey(x => x.id_lugar);
            });
            modelBuilder.Entity<Place>().OwnsOne(o => o.name, conf =>
            {
                conf.Property(x => x.value).HasColumnName("name");
            });
            modelBuilder.Entity<Place>().OwnsOne(o => o.id_region, conf =>
            {
                conf.Property(x => x.value).HasColumnName("id_region");
            });

            //PRODUCTOS
            modelBuilder.Entity<Product>(o =>
            {
                o.HasKey(x => x.id_product);
            });
            modelBuilder.Entity<Product>().OwnsOne(o => o.name_product, conf =>
            {
                conf.Property(x => x.value).HasColumnName("name_product");
            });
            modelBuilder.Entity<Product>().OwnsOne(o => o.type, conf =>
            {
                conf.Property(x => x.value).HasColumnName("type");
            });

            modelBuilder.Entity<Product>().OwnsOne(o => o.price, conf =>
            {
                conf.Property(x => x.value).HasColumnName("price");
            });
            modelBuilder.Entity<Product>().OwnsOne(o => o.units, conf =>
            {
                conf.Property(x => x.value).HasColumnName("units");
            });
            modelBuilder.Entity<Product>().OwnsOne(o => o.description, conf =>
            {
                conf.Property(x => x.value).HasColumnName("description");
            });

            // INVENTARIOS
            modelBuilder.Entity<Inventory>(o =>
            {
                o.HasKey(x => x.id_inventory);
            });
            modelBuilder.Entity<Inventory>().OwnsOne(o => o.id_user, conf =>
            {
                conf.Property(x => x.value).HasColumnName("id_user");
            });
            modelBuilder.Entity<Inventory>().OwnsOne(o => o.ability, conf =>
            {
                conf.Property(x => x.value).HasColumnName("ability");
            });
            //REGISTROS INVENTARIOS
            modelBuilder.Entity<RegisterInventory>(o =>
            {
                o.HasKey(x => x.id_register_inventory);
            });
            modelBuilder.Entity<RegisterInventory>().OwnsOne(o => o.id_inventory, conf =>
            {
                conf.Property(x => x.value).HasColumnName("id_inventory");
            });
            modelBuilder.Entity<RegisterInventory>().OwnsOne(o => o.id_product, conf =>
            {
                conf.Property(x => x.value).HasColumnName("id_product");
            });
            modelBuilder.Entity<RegisterInventory>().OwnsOne(o => o.quantity, conf =>
            {
                conf.Property(x => x.value).HasColumnName("quantity");
            });

            //REGISTROS LISTE DE COMPRAS
            modelBuilder.Entity<RLShop>(o =>
            {
                o.HasKey(x => x.id_register_l_compras);
            });
            modelBuilder.Entity<RLShop>().OwnsOne(o => o.id_shopList, conf =>
            {
                conf.Property(x => x.value).HasColumnName("id_shopList");
            });
            modelBuilder.Entity<RLShop>().OwnsOne(o => o.id_inventory, conf =>
            {
                conf.Property(x => x.value).HasColumnName("id_inventory");
            });

            modelBuilder.Entity<RLShop>().OwnsOne(o => o.quantity, conf =>
            {
                conf.Property(x => x.value).HasColumnName("quantity");
            });
            modelBuilder.Entity<RLShop>().OwnsOne(o => o.price, conf =>
            {
                conf.Property(x => x.value).HasColumnName("price");
            });
            modelBuilder.Entity<RLShop>().OwnsOne(o => o.units, conf =>
            {
                conf.Property(x => x.value).HasColumnName("units");
            });
            modelBuilder.Entity<RLShop>().OwnsOne(o => o.id_product, conf =>
            {
                conf.Property(x => x.value).HasColumnName("id_product");
            });



            //LISTA DE COMPRAS
            modelBuilder.Entity<ShopList>(o =>
            {
                o.HasKey(x => x.id_shopList);
            });
            modelBuilder.Entity<ShopList>().OwnsOne(o => o.id_user, conf =>
            {
                conf.Property(x => x.value).HasColumnName("id_user");
            });
            modelBuilder.Entity<ShopList>().OwnsOne(o => o.date, conf =>
            {
                conf.Property(x => x.value).HasColumnName("date");
            });
            modelBuilder.Entity<ShopList>().OwnsOne(o => o.subTotal, conf =>
            {
                conf.Property(x => x.value).HasColumnName("subTotal");
            });

            //PASOS RECETAS
            modelBuilder.Entity<Step>(o =>
            {
                o.HasKey(x => x.id_step);
            });
            modelBuilder.Entity<Step>().OwnsOne(o => o.id_prescription, conf =>
            {
                conf.Property(x => x.value).HasColumnName("id_prescription");
            });
            modelBuilder.Entity<Step>().OwnsOne(o => o.description, conf =>
            {
                conf.Property(x => x.value).HasColumnName("description");
            });
            //RECETAS
            modelBuilder.Entity<Prescription>(o =>
            {
                o.HasKey(x => x.id_prescription);
            });
            modelBuilder.Entity<Prescription>().OwnsOne(o => o.type_prescription, conf =>
            {
                conf.Property(x => x.value).HasColumnName("type_prescription");
            });
            modelBuilder.Entity<Prescription>().OwnsOne(o => o.name, conf =>
            {
                conf.Property(x => x.value).HasColumnName("name");
            });
            modelBuilder.Entity<Prescription>().OwnsOne(o => o.difficulty, conf =>
            {
                conf.Property(x => x.value).HasColumnName("difficulty");
            });
            modelBuilder.Entity<Prescription>().OwnsOne(o => o.time, conf =>
            {
                conf.Property(x => x.value).HasColumnName("time");
            });




            base.OnModelCreating(modelBuilder);
        }
    }
}
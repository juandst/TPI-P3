using Microsoft.EntityFrameworkCore;
using TP_Programación_III.Entities;
using TP_Programación_III.Enums;

namespace TP_Programación_III.Data.Context
{
    public class Context : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Sale> Sales { get; set; }

        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ID = 1,
                    Name = "Eukanuba Puppy x15",
                    Description = "Eukanuba Puppy es un producto ideal para mascotas menores al año de edad y entre 11 y 25 Kg. Considerado un alimento super premium, es de lo mejor que hay en el mercado",
                    ProductCategory = Category.AlimentoPerros,
                    Price = 14600,
                    HasDiscount = false,
                },
                new Product
                {
                    ID = 2,
                    Name = "Proplan Adult x3",
                    Description = "Proplan Adult es un producto ideal para mascotas mayores al año y con un peso menor a 10 kg. Considerado un alimento super premium, es de lo mejor que hay en el mercado",
                    ProductCategory = Category.AlimentoPerros,
                    Price = 4900,
                    HasDiscount = false,
                },
                new Product
                {
                    ID = 3,
                    Name = "Raza Adult x20",
                    Description = "Raza Adultos es un alimento masivo para perros adultos",
                    ProductCategory = Category.AlimentoPerros,
                    Price = 8100,
                    HasDiscount = true,
                }
                );

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    UserID = 1,
                    Name = "Pepito",
                    Email = "pepito@email.com",
                    Password = "123456",
                    IsAdmin = false,
                },
                new User
                {
                    UserID = 2,
                    Name = "Juan",
                    Email = "juan@email.com",
                    Password = "765432",
                    IsAdmin = true,
                },
                new User
                {
                    UserID = 3,
                    Name = "Carlos",
                    Email = "carlos@email.com",
                    Password = "123456",
                    IsAdmin = false,
                }
                );

            modelBuilder.Entity<Sale>().HasData(
                new Sale
                {
                    ID = 4,
                    PaymentType = PaymentType.CreditCard,
                    ShippingPlace = "Formosa",
                    Name = "Vitalcan Complete x20",
                    ProductCategory = Category.AlimentoPerros,
                    Price = 9500,
                }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}

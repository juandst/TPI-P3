﻿using Microsoft.EntityFrameworkCore;
using TP_Programación_III.Entities;

namespace TP_Programación_III.Data.Context
{
    public class Context : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }

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
                    ProductCategory = Enums.Category.AlimentoPerros,
                    Price = 14600,
                    OnSale = false,
                },
                new Product
                {
                    ID = 2,
                    Name = "Proplan Adult x3",
                    Description = "Proplan Adult es un producto ideal para mascotas mayores al año y con un peso menor a 10 kg. Considerado un alimento super premium, es de lo mejor que hay en el mercado",
                    ProductCategory = Enums.Category.AlimentoPerros,
                    Price = 4900,
                    OnSale = false,
                },
                new Product
                {
                    ID = 3,
                    Name = "Raza Adult x20",
                    Description = "Raza Adultos es un alimento masivo para perros adultos",
                    ProductCategory = Enums.Category.AlimentoPerros,
                    Price = 8100,
                    OnSale = true,
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

            base.OnModelCreating(modelBuilder);
        }
    }
}

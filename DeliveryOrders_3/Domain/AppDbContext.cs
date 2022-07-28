using DeliveryOrders_3.Models;
using Microsoft.EntityFrameworkCore;

namespace DeliveryOrders_3.Domain
{
    public class AppDbContext : DbContext
    {
        public DbSet<DeliveryOrder> DeliveryOrders { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)   { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DeliveryOrder>().HasData(new DeliveryOrder
            {
                Id = new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                SenderCity = "Санкт-Петербург",
                SenderAddress = "Улица им.Пушкина 36, кв 5",
                RecipientCity = "Москва",
                RecipientAddress = "Улица им.Колотушкина 56, кв 36",
                CargoWeight = 10.5M,
                DatePickup = new DateTime(2022, 8, 20)
            });

            modelBuilder.Entity<DeliveryOrder>().HasData(new DeliveryOrder
            {
                Id = new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                SenderCity = "Тольятти",
                SenderAddress = "Улица Баныкина 31, кв 65",
                RecipientCity = "Омск",
                RecipientAddress = "Улица Ленина 65, кв 23",
                CargoWeight = 3.5M,
                DatePickup = new DateTime(2022, 9, 2)
            });

            modelBuilder.Entity<DeliveryOrder>().HasData(new DeliveryOrder
            {
                Id = new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                SenderCity = "Самара",
                SenderAddress = "Улица Куйбышева 5, кв 51",
                RecipientCity = "Нижний Новгород",
                RecipientAddress = "Улица Рождественская 15, кв 7",
                CargoWeight = 5.3M,
                DatePickup = new DateTime(2022, 11, 23)
            });
        }
    }
}

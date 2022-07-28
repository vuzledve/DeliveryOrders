using DeliveryOrders_3.Models;
using Microsoft.EntityFrameworkCore;

namespace DeliveryOrders_3.Domain
{
    public class AppDbContext : DbContext
    {
        public DbSet<DeliveryOrder> DeliveryOrders { get; set; }

        /// <summary>
        /// </summary>

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
            // Database.EnsureCreated(); //https://ru.stackoverflow.com/questions/1098397/there-is-already-an-object-named-%D0%9D%D0%B0%D0%B7%D0%B2%D0%B0%D0%BD%D0%B8%D0%B5-in-the-database-%D0%BF%D1%80%D0%B8-%D0%B2%D1%8B%D0%BF%D0%BE%D0%BB%D0%BD%D0%B5%D0%BD%D0%B8%D0%B8-%D0%BC%D0%B8%D0%B3
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    var configuration = new ConfigurationBuilder()
        //        .SetBasePath(Directory.GetCurrentDirectory())
        //        .AddJsonFile("appsettings.json")
        //        .Build();

        //    var connectionString = configuration.GetConnectionString("AppDb");
        //    optionsBuilder.UseSqlServer(connectionString);
        //}

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

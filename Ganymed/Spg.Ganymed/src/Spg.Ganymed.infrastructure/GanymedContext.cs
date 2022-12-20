using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Spg.Ganymed.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Ganymed.Infrastructure
{
    // 1. muss von DbContext ableiten
    public class GanymedContext : DbContext
    {
        // 2. die Tabellen der Datenbank als Properties auflisten
        public DbSet<User> Users => Set<User>();
        public DbSet<Cart> Carts => Set<Cart>();
        public DbSet<CartEntry> CartEntries => Set<CartEntry>();
        public DbSet<Equipment> Equipment => Set<Equipment>();
        public DbSet<EquipmentType> EquipmentTypes => Set<EquipmentType>(); 
        public DbSet<Happening> Happenings => Set<Happening>();
        public DbSet<HappeningLocation> HappeningLocations => Set<HappeningLocation>();
        public DbSet<Warehouse> Warehouses => Set<Warehouse>();
        public DbSet<WarehousePosition> WarehousePositions => Set<WarehousePosition>();

        // 3. Constructor
        public GanymedContext()
        { }

        public GanymedContext(DbContextOptions options)
            : base(options)
        { }

        // 4. Konfiguration vor DB Erstellung
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            /*
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("");
            }   
            */
        }

        // 5. Optionen während DB Erstellung
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EquipmentType>().HasKey(p => p.Type);
            modelBuilder.Entity<EquipmentType>().Property(p => p.Type).IsRequired();

            //Value Object
            modelBuilder.Entity<HappeningLocation>().OwnsOne(p => p.Address);
            modelBuilder.Entity<Warehouse>().OwnsOne(p => p.Address);
        }

        public void Seed()
        {
            Randomizer.Seed = new Random(2312);

            List<User> users = new Faker<User>().CustomInstantiator(f =>
                new User(
                    f.Random.Enum<Genders>(),
                    f.Name.FirstName(Bogus.DataSets.Name.Gender.Female),
                    f.Name.LastName(),
                    f.Internet.UserName(),
                    f.Internet.Email(),
                    f.Random.Hash(),
                    f.Date.Between(DateTime.Now.AddYears(-10), DateTime.Now)
                ))
                .Rules((f, u) =>
                {
                    if(u.Gender == Genders.Male)
                    {
                        u.FirstName = f.Name.FirstName(Bogus.DataSets.Name.Gender.Male);
                    }
                })
                .Generate(10)
                .ToList();
            Users.AddRange(users);
            SaveChanges();

            List<Cart> carts = new Faker<Cart>().CustomInstantiator(f =>
                new Cart(CartStates.Sent, f.Random.ListItem(users))
             )
            .Rules((f, c) =>
             {
                 c.UserNavigationId = f.Random.Int(0, 10);
             })
            .Generate(200)
            .ToList();
            Carts.AddRange(carts);
            SaveChanges();

            List<Happening> happenings = new Faker<Happening>().CustomInstantiator(f =>
                new Happening(
                    f.Date.Between(DateTime.Now.AddDays(-10), DateTime.Now.AddDays(-8)),
                    f.Date.Between(DateTime.Now.AddDays(-8), DateTime.Now.AddDays(-5))
                    )
            )
            .Generate(30)
            .ToList();
            Happenings.AddRange(happenings);
            SaveChanges();

            List<HappeningLocation> happeningLocation = new Faker<HappeningLocation>().CustomInstantiator(f =>
                new HappeningLocation(
                    new Address(
                        f.Address.StreetName(), 
                        f.Address.BuildingNumber(), 
                        f.Random.Number(1000, 9999), 
                        f.Address.City()
                        )
                    )
            )
            .Generate(50)
            .ToList();
            HappeningLocations.AddRange(happeningLocation);
            SaveChanges();

            List<string> type = new List<string>() { "Beamer", "Stele", "Leinwand", "Kabel", "Bühne", "Mischpult", "Lampe" };
            List<EquipmentType> equipmentType = new Faker<EquipmentType>().CustomInstantiator(f =>
                new EquipmentType(f.Random.ListItem(type))
            )
            .Generate(50)
            .GroupBy(e => e.Type)
            .Select(e => e.First())
            .ToList();

            EquipmentTypes.AddRange(equipmentType);
            SaveChanges();

            List < Warehouse > warehouse = new Faker<Warehouse>().CustomInstantiator(f =>
                new Warehouse(
                    new Address(
                        f.Address.StreetName(),
                        f.Address.BuildingNumber(),
                        f.Random.Number(1000, 9999),
                        f.Address.City()
                        )
                    )
            )
            .Generate(4)
            .ToList();
            Warehouses.AddRange(warehouse);
            SaveChanges();

            List<string> room = new List<string> { "A1", "A2", "B1", "B2" };
            List<string> shelf = new List<string> { "S1", "S2", "S3", "S4", "S5", "S6", "S7" };
            List<string> level = new List<string> { "L1", "L2", "L3" };
            List<string> compartment = new List<string> { "A", "B", "C", "D" };
            List < WarehousePosition > warehousePositions = new Faker<WarehousePosition>().CustomInstantiator(f =>
                new WarehousePosition(
                    f.Random.ListItem(room),
                    f.Random.ListItem(shelf),
                    f.Random.ListItem(level),
                    f.Random.ListItem(compartment),
                    f.Random.ListItem(warehouse)
                    )
            )
            .Generate(30)
            .ToList();
            WarehousePositions.AddRange(warehousePositions);
            SaveChanges();


            List<Equipment> equipment = new Faker<Equipment>().CustomInstantiator(f =>
                new Equipment(f.Name.FirstName(), f.Lorem.Sentence(5, 1), true, 
                    f.Random.ListItem(happeningLocation), 
                    f.Random.ListItem(equipmentType),
                    f.Random.ListItem(warehousePositions)
                    )
            )
            .Generate(50)
            .ToList();
            Equipment.AddRange(equipment);
            SaveChanges();

            List<CartEntry> cartEntries = new Faker<CartEntry>().CustomInstantiator(f =>
                new CartEntry(
                    f.Random.ListItem(happenings),
                    f.Random.ListItem(carts),
                    f.Random.ListItem(equipment)
                    )
            )
            .Generate(20)
            .ToList();
            CartEntries.AddRange(cartEntries);
            SaveChanges();
        }
    }
}

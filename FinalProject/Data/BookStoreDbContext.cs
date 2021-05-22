using System;
using System.Collections.Generic;
using System.Text;
using FinalProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Data
{
    public class BookStoreDbContext : DbContext
    {
        public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Store> Stores { get; set; }

        public void InitData()
        {
            var store = new Store
            {
                Name = "test",
                Lontitude = 32,
                Latitude = 32,
                OpeningHour = "10:00",
                ClosingHour = "22:00"
            };
            var store2 = new Store
            {
                Name = "store2",
                Lontitude = 34,
                Latitude = 34,
                OpeningHour = "08:00",
                ClosingHour = "20:00"
            };
            this.Stores.AddRange(store,store2);

            SaveChanges();
        }
    }
}

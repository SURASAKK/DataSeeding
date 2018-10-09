using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace Dataseeding.Models
{
    public class Users
    {
        [Key]
        public int Id { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Email { set; get; }
    }

    public class DataSeedContext : DbContext
    {
        public DataSeedContext(DbContextOptions<DataSeedContext> options) : base(options) { }

        public DbSet<Users> Users { set; get; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>().HasData(
                new Users { Id = 1, FirstName = "admin1", LastName = "1234" },
                new Users { Id = 2, FirstName = "admin2", LastName = "1234" }
            );
        }
    }
}
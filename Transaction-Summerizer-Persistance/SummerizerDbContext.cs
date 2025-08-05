using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transaction_Summerizer_Models;

namespace Transaction_Summerizer_Persistance
{
    public class SummerizerDbContext : DbContext
    {
      

        public DbSet<Users> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = "Server=localhost;Database=TransactionSummerizer;Trusted_Connection=True;Encrypt=False;";
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed Categories first
            modelBuilder.Entity<Categories>().HasData(
                new Categories
                {
                    ID = 1,
                    Name = CategoryType.Groceries,
                    Type = "Expense"

                }
            );

            // Seed UserDTO using FK to Category
            modelBuilder.Entity<Users>().HasData(
                new Users
                {
                    ID = 1,
                    Name = "Chathuni",
                    TimeStamp = new DateTime(2024, 8, 1), // Must be hard-coded
                    TotalSpent = 150.50,
                    CategoryID = 1
                }
            );
        }

    }
}
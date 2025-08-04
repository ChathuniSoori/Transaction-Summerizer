using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transaction_Summerizer_Models;

namespace Transaction_Summerizer_Persistance
{
    public class SummerizerContext : DbContext
    {
        public SummerizerContext(DbContextOptions<SummerizerContext> options) : base(options) { }

        public DbSet<UserDTO> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Data Seeding
            modelBuilder.Entity<UserDTO>().HasData(
                new UserDTO
                {
                    ID = 1,
                    Name = "Chathuni",
                    TimeStamp = DateTime.UtcNow.AddDays(-1),
                    TotalSpent = 150.50,
                    Category = new CategoryDTO { Name = CategoryType.Groceries, Type = "Expense" }
                },
                new UserDTO
                {
                    ID = 2,
                    Name = "Monali",
                    TimeStamp = DateTime.UtcNow.AddDays(-2),
                    TotalSpent = 80.00,
                    Category = new CategoryDTO { Name = CategoryType.Entertainment, Type = "Expense" }
                }
            );
        }
    }
}
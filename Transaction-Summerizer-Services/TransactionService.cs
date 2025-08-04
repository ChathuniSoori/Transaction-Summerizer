using System;
using System.Collections.Generic;
using System.Linq;
using Transaction_Summerizer_Models;

namespace Transaction_Summerizer.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly List<UserDTO> _userTransactions = new();

        public TransactionService()
        {
            // Preload with 6 users
            _userTransactions.AddRange(new List<UserDTO>
            {
                new UserDTO
                {
                    ID = 1,
                    Name = "Alice",
                    TimeStamp = DateTime.UtcNow.AddDays(-1),
                    TotalSpent = 150.50,
                    Category = new CategoryDTO { Name = CategoryType.Groceries, Type = "Expense" }
                },
                new UserDTO
                {
                    ID = 2,
                    Name = "Bob",
                    TimeStamp = DateTime.UtcNow.AddDays(-2),
                    TotalSpent = 80.00,
                    Category = new CategoryDTO { Name = CategoryType.Transport, Type = "Expense" }
                },
                new UserDTO
                {
                    ID = 3,
                    Name = "Charlie",
                    TimeStamp = DateTime.UtcNow.AddDays(-3),
                    TotalSpent = 200.75,
                    Category = new CategoryDTO { Name = CategoryType.Shopping, Type = "Expense" }
                },
                new UserDTO
                {
                    ID = 4,
                    Name = "Diana",
                    TimeStamp = DateTime.UtcNow.AddDays(-4),
                    TotalSpent = 55.20,
                    Category = new CategoryDTO { Name = CategoryType.Health, Type = "Expense" }
                },
                new UserDTO
                {
                    ID = 5,
                    Name = "Ethan",
                    TimeStamp = DateTime.UtcNow.AddDays(-5),
                    TotalSpent = 500.00,
                    Category = new CategoryDTO { Name = CategoryType.Rent, Type = "Expense" }
                },
                new UserDTO
                {
                    ID = 6,
                    Name = "Fiona",
                    TimeStamp = DateTime.UtcNow.AddDays(-6),
                    TotalSpent = 75.30,
                    Category = new CategoryDTO { Name = CategoryType.Entertainment, Type = "Expense" }
                }
            });
        }

        public UserDTO AddTransaction(UserDTO userDTO)
        {
            userDTO.ID = _userTransactions.Any() ? _userTransactions.Max(x => x.ID) + 1 : 1;
            _userTransactions.Add(userDTO);
            return userDTO;
        }

        public UserDTO GetTransactionById(int id)
        {
            return _userTransactions.FirstOrDefault(x => x.ID == id);
        }

        public List<UserDTO> GetAllTransactions()
        {
            return _userTransactions;
        }
    }
}

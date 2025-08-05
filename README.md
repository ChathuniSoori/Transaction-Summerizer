# 💸 Transaction Summarizer API

This is a beginner-friendly `.NET Core Web API` project called **Transaction Summarizer**, designed to:
- Accept and store user transactions
- Retrieve all or individual user summaries
- Display categorized expenses
- Use clean architecture, SOLID principles, and design patterns

---

## 🧱 Project Folder Structure

Transaction_Summerizer/
│
├── Controllers/
│ └── TransactionController.cs 👈 Handles HTTP endpoints
│
├── Models/ (or Transaction_Summerizer_Models/)
│ ├── UserDTO.cs 👈 Data structure for user & transaction
│ └── CategoryDTO.cs 👈 Transaction category info
│
├── Services/
│ ├── ITransactionService.cs 👈 Interface for business logic
│ └── TransactionService.cs 👈 Service implementing the logic
│
└── README.md 👈 Project guide


---

## 🧠 SOLID + Design Patterns Used

| Principle / Pattern       | Usage Example                                          |
|--------------------------|--------------------------------------------------------|
| 🧩 SRP (Single Responsibility) | Each class has one job (Controller vs Service)       |
| 🚪 DIP (Dependency Inversion) | Controller depends on `ITransactionService`          |
| 📦 Repository/Service Pattern | `TransactionService` separates logic from controller |
| 📋 DTO Pattern              | `UserDTO`, `CategoryDTO` to pass structured data      |

---

## ⚙️ API Endpoints

### ➕ POST /api/transaction
Creates a new transaction (not implemented yet).

### 📥 GET /api/transaction
Returns all transactions.

### 📥 GET /api/transaction/{id}
Returns a transaction summary for a specific user.

---

## 🧪 Sample Data (Preloaded in Service)

```csharp
new UserDTO
{
    ID = 1,
    Name = "Alice",
    TimeStamp = DateTime.UtcNow.AddDays(-1),
    TotalSpent = 150.50,
    Category = new CategoryDTO { Name = CategoryType.Groceries, Type = "Expense" }
}

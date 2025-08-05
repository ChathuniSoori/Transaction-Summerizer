using System;
using System.ComponentModel.DataAnnotations;

namespace Transaction_Summerizer_Models
{
    public class UserDTO
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime TimeStamp { get; set; }
        public double TotalSpent { get; set; }

        public int CategoryID { get; set; }               // FK
        public CategoryDTO Category { get; set; }         // Navigation property
    }

    public class CategoryDTO
    {
        [Key]
        public int ID { get; set; }
        public CategoryType Name { get; set; }  // enum
        public string Type { get; set; }

        public ICollection<UserDTO> Users { get; set; }   // Optional: reverse navigation
    }


    public enum CategoryType
    {
        Groceries,         // 0
        Transport,         // 1
        Entertainment,     // 2
        Health,            // 3
        Education,         // 4
        Rent,              // 5
        Shopping           // 6
    }


}

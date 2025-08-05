using System;
using System.ComponentModel.DataAnnotations;

namespace Transaction_Summerizer_Models
{
    public class Users
    {

        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Name cannot be longer than 100 characters.")]
        public string Name { get; set; }

        [Required]
        public DateTime TimeStamp { get; set; }

        [Required]
        public double TotalSpent { get; set; }

        public int?  CategoryID { get; set; }             // FK
        public Categories Category { get; set; }         // Navigation property
    }

    public class Categories
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public CategoryType Name { get; set; }  // enum

        [StringLength(100, ErrorMessage = "Type cannot be longer than 100 characters.")]
        public string Type { get; set; }

        public ICollection<Users> Users { get; set; } = new List<Users>();   // Optional: reverse navigation
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

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

        public CategoryDTO Category { get; set; }
    }

    public class CategoryDTO
    {
        public CategoryType Name { get; set; }  // enum instead of string
        public string Type { get; set; } 
    }

    public enum CategoryType
    {
        Groceries,
        Transport,
        Entertainment,
        Health,
        Education,
        Rent,
        Shopping
    }

}

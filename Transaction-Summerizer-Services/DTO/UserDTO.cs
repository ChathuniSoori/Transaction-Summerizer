using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transaction_Summerizer_Models;

namespace Transaction_Summerizer_Services.DTO
{
    public class UserDTO
    {
        public int ID { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Name cannot be longer than 100 characters.")]
        public string Name { get; set; }

        [Required]
        public DateTime TimeStamp { get; set; }

        [Required]
        public double TotalSpent { get; set; }

        public int? CategoryID { get; set; }             // FK
        public Categories Category { get; set; }


    }
}

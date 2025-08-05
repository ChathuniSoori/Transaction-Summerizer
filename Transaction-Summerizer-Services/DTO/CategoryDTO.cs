using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transaction_Summerizer_Models;

namespace Transaction_Summerizer_Services.DTO
{
    public class CategoryDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }  // Enum as string
        public string Type { get; set; }  // Optional: could be used for additional info
        // Optional: Navigation property for reverse relationship
         
    }
}

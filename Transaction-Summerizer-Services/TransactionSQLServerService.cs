using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transaction_Summerizer.Services;
using Transaction_Summerizer_Models;
using Transaction_Summerizer_Persistance;

namespace Transaction_Summerizer_Services
{
    public class TransactionSQLServerService : ITransactionService

    {
        private readonly SummerizerDbContext _context= new SummerizerDbContext();
        public List<UserDTO> GetAllTransactions()
        {
            return _context.Users.ToList();
        }
    }
}

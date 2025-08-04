using Transaction_Summerizer_Models;
using System.Collections.Generic;

namespace Transaction_Summerizer.Services
{
    public interface ITransactionService
    {
        //UserDTO AddTransaction(UserDTO userDTO);
        //UserDTO GetTransactionById(int id);
        public List<UserDTO> GetAllTransactions();
    }
}

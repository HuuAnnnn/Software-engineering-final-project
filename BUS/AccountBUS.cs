using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class AccountBUS
    {
        private AccountDAO accountDAO;
        public AccountBUS()
        {
            accountDAO = new AccountDAO();
        }

        public AccountBUS(String username, String password)
        {
            accountDAO = new AccountDAO(username, password, 0);
        }

        public bool isExistsUser()
        {
            return accountDAO.isExistsUser();
        }

        public bool isAuthUser()
        {
            return accountDAO.isAuthUser();
        }

        public Account getAccount()
        {
            return accountDAO.getAccount();
        }
    }
}

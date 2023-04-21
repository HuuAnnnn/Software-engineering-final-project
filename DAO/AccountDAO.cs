using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class AccountDAO
    {
        private Account account;
        public AccountDAO()
        {
            Connection.connect();
        }

        public AccountDAO(String username, String password, int count)
        {
            Connection.connect();
            account = new Account(username, password, count);
        }

        public bool isExistsUser()
        {
            String query = string.Format("SELECT * FROM Account WHERE username = '{0}'", account.EmployeeID);
            DataTable result = Connection.selectQuery(query);
            return result.Rows.Count > 0;
        }

        public bool isAuthUser()
        {
            String query = string.Format("SELECT * FROM Account WHERE username = '{0}' and password='{1}'", account.EmployeeID, account.Password);
            DataTable result = Connection.selectQuery(query);
            return result.Rows.Count > 0;
        }
    }
}

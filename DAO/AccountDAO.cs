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
            account = new Account(username, password, count, "");
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

        public Account getAccount()
        {
            Account logedAccount = null;
            String query = string.Format("SELECT * FROM ACCOUNT WHERE USERNAME = '{0}'", account.EmployeeID);
            DataTable queryResult = Connection.selectQuery(query);
            string username;
            string role;
            int timesChangePassword;
            foreach (DataRow row in queryResult.Rows)
            {

                username = row["username"].ToString();
                role = row["username"].ToString();
                timesChangePassword = int.Parse(row["timesChangePassword"].ToString());
                logedAccount = new Account(username, "", timesChangePassword, role);
            }

            return logedAccount;
        }
    }
}

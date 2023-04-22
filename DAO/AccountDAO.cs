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
            string hashedPassword = Configuration.Config.hash(password);
            account = new Account(username, hashedPassword, count, "");
        }

        public bool isExistsUser()
        {
            String query = string.Format("SELECT * FROM Account WHERE username = '{0}'", account.EmployeeID);
            DataTable result = Connection.selectQuery(query);
            return result.Rows.Count > 0;
        }

        public bool isAuthUser()
        {
            string query = string.Format("SELECT * FROM Account WHERE username = '{0}' and password='{1}'", account.EmployeeID, account.Password);
            DataTable result = Connection.selectQuery(query);
            return result.Rows.Count == 1;
        }

        public Account getAccount()
        {
            Account logedAccount = null;
            String query = string.Format("SELECT * FROM ACCOUNT WHERE USERNAME = '{0}' and password = '{1}'", account.EmployeeID, account.Password);
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

        public bool isAuthenticationUser(string password)
        {
            String query = string.Format("SELECT * FROM ACCOUNT WHERE USERNAME = '{0}' AND PASSWORD = '{1}'", account.EmployeeID, password);
            DataTable result = Connection.selectQuery(query);
            return result.Rows.Count > 0;
        }

        public bool isTrueUser()
        {
            String query = string.Format("SELECT * FROM ACCOUNT WHERE USERNAME = '{0}' AND PASSWORD = '{1}'", account.EmployeeID, account.Password);
            DataTable result = Connection.selectQuery(query);
            return result.Rows.Count == 1;
        }

        public bool changePassword(string newPassword)
        {
            string hashPassword = Configuration.Config.hash(newPassword);
            string query = "UPDATE ACCOUNT SET PASSWORD = @PASSWORD, TIMESCHANGEPASSWORD = TIMESCHANGEPASSWORD + 1 WHERE USERNAME = @USERNAME";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.Add("@PASSWORD", SqlDbType.NVarChar, 255);
            command.Parameters["@PASSWORD"].Value = hashPassword;
            command.Parameters.Add("@USERNAME", SqlDbType.NVarChar, 50);
            command.Parameters["@USERNAME"].Value = account.EmployeeID;

            Connection.actionQuery(command);

            return isAuthenticationUser(hashPassword);
        }
    }
}

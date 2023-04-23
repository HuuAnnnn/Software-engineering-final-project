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
    public class CustomerDAO
    {
        private Customer customer;
        public CustomerDAO()
        {
            Connection.connect();
        }

        public CustomerDAO(String phone, String fullName)
        {
            customer = new Customer(phone, fullName, 0);
        }

        public bool isCustomerExists()
        {
            string query = string.Format("select * from customer where id = '{0}'", customer.Phone);
            return Connection.selectQuery(query).Rows.Count > 0;
        }

        public bool insertNewCustomer()
        {
            SqlCommand command = new SqlCommand("INSERT INTO CUSTOMER VALUES (@PHONE, @FULLNAME, @POINT)");
            command.Parameters.Add("@PHONE", SqlDbType.NVarChar, 50);
            command.Parameters["@PHONE"].Value = customer.Phone;
            command.Parameters.Add("@FULLNAME", SqlDbType.NVarChar, 255);
            command.Parameters["@FULLNAME"].Value = customer.FullName;
            command.Parameters.Add("@POINT", SqlDbType.Int);
            command.Parameters["@POINT"].Value = customer.Point;

            Connection.actionQuery(command);

            return isCustomerExists();
        }
    }
}

using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ReceiptDAO
    {
        private Receipt receipt;
        
        public ReceiptDAO()
        {
            Connection.connect();
        }

        public ReceiptDAO(string dateCreated, double total, string employeeID, string customerID)
        {
            Connection.connect();
            receipt = new Receipt(generateReceiptId(), dateCreated, total, employeeID, customerID, null, "not pay");
        }

        public Receipt getReceipt()
        {
            return receipt;
        }

        private int getNextReceiptId()
        {
            String query = "select top 1 id from receipt order by id desc";
            DataTable result = Connection.selectQuery(query);
            string currentId = "";
            foreach (DataRow row in result.Rows)
            {
                currentId = row["id"].ToString();
                break;
            }

            int nextId = int.Parse(currentId.Substring(currentId.Length - 3)) + 1;

            return nextId;
        }

        private string generateReceiptId()
        {
            int id = getNextReceiptId();
            return DateTime.Now.ToString("yyyymmdd") + ("" + id).PadLeft(3, '0');
        }

        public void insertNewReceipt()
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "INSERT INTO RECEIPT VALUES (@id, @dateCreate, @total, @employeeId, @customerId, 'not paid')";
            command.Parameters.Add("@id", SqlDbType.VarChar, 50);
            command.Parameters["@id"].Value = receipt.ReceiptID;
            command.Parameters.Add("@dateCreate", SqlDbType.Date, 50);
            command.Parameters["@dateCreate"].Value = receipt.DateCreated;
            command.Parameters.Add("@total", SqlDbType.Float);
            command.Parameters["@total"].Value = receipt.Total;
            command.Parameters.Add("@employeeId", SqlDbType.NVarChar, 50);
            command.Parameters["@employeeId"].Value = receipt.EmployeeID;
            command.Parameters.Add("@customerId", SqlDbType.NVarChar, 50);
            command.Parameters["@customerId"].Value = receipt.Customer;
            Connection.actionQuery(command);
        }

        public DataTable selectTotalRevenueInDay(string startDate, string endDate)
        {
            string selectQuery = "SELECT t1.dateCreated, SUM(t1.total) as totalInDay"
                                + " FROM(SELECT * FROM Receipt WHERE dateCreated BETWEEN '" + startDate + "' AND '" + endDate + "') as t1"
                                + " GROUP BY t1.dateCreated"
                                + " ORDER BY t1.dateCreated Desc";
            
            return Connection.selectQuery(selectQuery);
        }
    }
}

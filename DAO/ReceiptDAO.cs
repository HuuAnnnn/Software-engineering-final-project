using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
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
            String query = string.Format("select top 1 id from receipt where dateCreate = '{0}' order by id desc", DateTime.Now.ToString("yyyy-MM-dd"));
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

        public string generateReceiptId()
        {
            int id = getNextReceiptId();
            return DateTime.Today.ToString("yyyyMMdd") + ("" + id).PadLeft(3, '0');
        }

        public void insertNewReceipt()
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "INSERT INTO RECEIPT VALUES (@id, @dateCreate, @total, @employeeId, @customerId, 'not pay')";
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

        public DataTable selectTop10Product(string startDate, string endDate)
        {
            string selectQuery = "SELECT TOP 10 t4.*, Product.productName FROM Product, (SELECT t3.productID, SUM(t3.total) as totalOfProduct FROM(SELECT t2.*, Product.productName FROM Product, (SELECT ReceiptLine.* FROM ReceiptLine, (SELECT receiptID FROM Receipt WHERE dateCreated BETWEEN '" + startDate + "' AND '" + endDate + "') as t1 WHERE ReceiptLine.receiptID = t1.receiptID) as t2 WHERE t2.productID = Product.productID) as t3 GROUP BY t3.productID) as t4 WHERE t4.productID = Product.productID ORDER BY t4.totalOfProduct Desc";

            return Connection.selectQuery(selectQuery);
        }
        public Receipt getCurrentReceipt()
        {
            string query = string.Format("select * from receipt where receiptState = 'not pay' and dateCreate = '{0}'", DateTime.Today.ToString("yyyy-MM-dd"));
            DataTable dataTable = Connection.selectQuery(query);
            Receipt receipt = null;
            foreach (DataRow row in dataTable.Rows)
            {
                receipt = new Receipt(
                    row["id"].ToString(),
                    row["dateCreate"].ToString(),
                    double.Parse(row["total"].ToString()),
                    row["employeeID"].ToString(),
                    row["customerId"].ToString(),
                    null,
                    row["receiptState"].ToString()
                 ); ;
            }

            return receipt;
        }
    }
}

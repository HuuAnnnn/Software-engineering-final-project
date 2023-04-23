using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ImportReceiptDAO
    {
        ImportReceipt importReceipt;

        public ImportReceiptDAO(string dateCreated, double total, bool stateAccept, string employeeID)
        {
            Connection.connect();
            importReceipt = new ImportReceipt(generateImportReceiptId(), dateCreated, total, stateAccept, employeeID);
        }

        public ImportReceipt getImportReceipt()
        {
            return this.importReceipt;
        }

        private int getNextReceiptId()
        {
            String query = "select top 1 id from ImportReceipt order by id desc";
            DataTable result = Connection.selectQuery(query);
            string currentId = "";

            if (result.Rows.Count > 0)
            {
                foreach (DataRow row in result.Rows)
                {
                    currentId = row["id"].ToString();
                    break;
                }

                int nextId = int.Parse(currentId.Substring(currentId.Length - 3)) + 1;

                return nextId;
            }

            return 1;
        }

        public string generateImportReceiptId()
        {
            int id = getNextReceiptId();
            return "NH" + DateTime.Today.ToString("yyyyMMdd") + ("" + id).PadLeft(3, '0');
        }

        public void insertNewImportReceipt()
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "INSERT INTO ImportReceipt VALUES (@id, @dateCreated, @total, @StateAccept, @employeeId)";
            command.Parameters.Add("@id", SqlDbType.VarChar, 50);
            command.Parameters["@id"].Value = importReceipt.ImportReceiptID;
            command.Parameters.Add("@dateCreated", SqlDbType.Date, 50);
            command.Parameters["@dateCreated"].Value = importReceipt.DateCreated;
            command.Parameters.Add("@total", SqlDbType.Float);
            command.Parameters["@total"].Value = importReceipt.Total;
            command.Parameters.Add("@employeeId", SqlDbType.NVarChar, 50);
            command.Parameters["@employeeId"].Value = importReceipt.EmployeeID;
            command.Parameters.Add("@StateAccept", SqlDbType.NVarChar, 50);
            command.Parameters["@StateAccept"].Value = importReceipt.StateAccept;
            Connection.actionQuery(command);
        }

    }
}

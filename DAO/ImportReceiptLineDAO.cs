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
    public class ImportReceiptLineDAO
    {
        private ImportReceiptLine importReceiptLine;
        public ImportReceiptLineDAO(string importReceitptId, string productID, int quantity, double total)
        {
            Connection.connect();
            importReceiptLine = new ImportReceiptLine(importReceitptId, productID, quantity, total);
        }

        public void insertNewRecord()
        {
            SqlCommand command = new SqlCommand("INSERT INTO IMPORTRECEIPTLINE VALUES (@importReceiptId, @productId, @quantity, @total)");
            command.Parameters.Add("@importReceiptId", SqlDbType.NVarChar, 50);
            command.Parameters["@importReceiptId"].Value = importReceiptLine.ImportReceiptId;
            command.Parameters.Add("@productId", SqlDbType.NVarChar, 50);
            command.Parameters["@productId"].Value = importReceiptLine.ProductID;
            command.Parameters.Add("@QUANTITY", SqlDbType.Int);
            command.Parameters["@QUANTITY"].Value = importReceiptLine.Quantity;
            command.Parameters.Add("@TOTAL", SqlDbType.Float);
            command.Parameters["@TOTAL"].Value = importReceiptLine.Total;

            Connection.actionQuery(command);
        }
    }
}

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
    public class ReceiptLineDAO
    {
        private ReceiptLine receiptLine;
        public ReceiptLineDAO(string orderId, String productId, int quantity, double total)
        {
            Connection.connect();
            receiptLine = new ReceiptLine(orderId, productId, quantity, total);
        }

        public void insertNewRecord()
        {
            SqlCommand command = new SqlCommand("INSERT INTO RECEIPTLINE VALUES (@ORDER_ID, @PRODUCT_ID, @QUANTITY, @TOTAL)");
            command.Parameters.Add("@ORDER_ID", SqlDbType.NVarChar, 50);
            command.Parameters["@ORDER_ID"].Value = receiptLine.OrderId;
            command.Parameters.Add("@PRODUCT_ID", SqlDbType.NVarChar, 50);
            command.Parameters["@PRODUCT_ID"].Value = receiptLine.ProductID;
            command.Parameters.Add("@QUANTITY", SqlDbType.Int);
            command.Parameters["@QUANTITY"].Value = receiptLine.Quantity;
            command.Parameters.Add("@TOTAL", SqlDbType.Float);
            command.Parameters["@TOTAL"].Value = receiptLine.Total;

            Connection.actionQuery(command);
        }
    }
}

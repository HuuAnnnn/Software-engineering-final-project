using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ReceiptLineBUS
    {
        private ReceiptLineDAO receiptLineDAO;

        public ReceiptLineBUS(string orderId, string productId, int quantity, double total)
        {
            receiptLineDAO = new ReceiptLineDAO(orderId, productId, quantity, total);
        }

        public void insertOrderLine()
        {
            receiptLineDAO.insertNewRecord();
        }
    }
}

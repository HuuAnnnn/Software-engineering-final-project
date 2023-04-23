using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ReceiptBUS
    {
        private ReceiptDAO receiptDAO;
        public ReceiptBUS()
        {
            Connection.connect();
            receiptDAO = new ReceiptDAO();
        }

        public ReceiptBUS(string dateCreated, double total, string employeeID, string customerID)
        {
            Connection.connect();
            receiptDAO = new ReceiptDAO(dateCreated, total, employeeID, customerID);
        }

        public Receipt getReceipt()
        {
            return receiptDAO.getReceipt();
        }

        public void createNewReceipt()
        {
            receiptDAO.insertNewReceipt();
        }
    }
}

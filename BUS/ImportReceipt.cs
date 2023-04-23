using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ImportReceiptBUS
    {
        ImportReceiptDAO importReceiptDAO;
        public ImportReceiptBUS(string dateCreated, double total, bool stateAccept, string employeeID)
        {
            importReceiptDAO = new ImportReceiptDAO(dateCreated, total, stateAccept, employeeID);
        }

        public ImportReceipt getImportReceipt()
        {
            return importReceiptDAO.getImportReceipt();
        }

        public void createNewReceipt()
        {
            importReceiptDAO.insertNewImportReceipt();
        }

    }
}

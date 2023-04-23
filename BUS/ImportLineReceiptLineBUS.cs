using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ImportLineReceiptLineBUS
    {
        private ImportReceiptLineDAO importLineDAO;

        public ImportLineReceiptLineBUS(string importLineId, string productId, int quantity, double total)
        {
            importLineDAO = new ImportReceiptLineDAO(importLineId, productId, quantity, total);
        }

        public void insertImportReceiptLine()
        {
            importLineDAO.insertNewRecord();
        }
    }
}

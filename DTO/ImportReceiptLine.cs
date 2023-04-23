using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ImportReceiptLine
    {
        public ImportReceiptLine(string importReceitptId, string productID, int quantity, double total)
        {
            this.ImportReceiptId = importReceitptId;
            this.ProductID = productID;
            this.Quantity = quantity;
            this.Total = total;
        }

        public string ImportReceiptId { get; set; }

        public string ProductID { get; set; }

        public int Quantity { get; set; }

        public double Total { get; set; }
    }
}

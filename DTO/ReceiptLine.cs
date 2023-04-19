using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ReceiptLine
    {
        public ReceiptLine(string productID, int quantity, int total)
        {
            this.ProductID = productID;
            this.Quantity = quantity;
            this.Total = total;
        }

        public string ProductID { get; set; }

        public int Quantity { get; set; }

        public int Total { get; set; }
    }
}
    
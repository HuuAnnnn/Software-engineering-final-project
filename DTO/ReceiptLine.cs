using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ReceiptLine
    {
        public ReceiptLine(string orderId, string productID, int quantity, double total)
        {
            this.OrderId = orderId;
            this.ProductID = productID;
            this.Quantity = quantity;
            this.Total = total;
        }

        public string ProductID { get; set; }
        public string OrderId { get; set; }

        public int Quantity { get; set; }

        public double Total { get; set; }
    }
}
    
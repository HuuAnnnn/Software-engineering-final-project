using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Receipt
    {
        public Receipt(string receiptID, string dateCreated, int total)
        {
            this.ReceiptID = receiptID;
            this.DateCreated = dateCreated;
            this.Total = total;
        }

        public string ReceiptID { get; set; }

        public string DateCreated { get; set; }

        public int Total { get; set; }
    }
}

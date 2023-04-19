using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Receipt
    {
        public Receipt(string receiptID, string dateCreated, int total, string employeeID, string customerID, List<ReceiptLine> receiptLines)
        {
            this.ReceiptID = receiptID;
            this.DateCreated = dateCreated;
            this.Total = total;
            this.EmployeeID = employeeID;
            this.Customer = customerID;
            this.ReceiptLines = receiptLines;
        }

        public string ReceiptID { get; set; }

        public string DateCreated { get; set; }

        public int Total { get; set; }

        public string EmployeeID { get; set; }

        public string Customer { get; set; }

        public List<ReceiptLine> ReceiptLines { get; set; }
    }
}

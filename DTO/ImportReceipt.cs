using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ImportReceipt
    {
        public ImportReceipt(string importReceiptID, string dateCreated, double total, bool stateAccept, string employeeID)
        {
            this.ImportReceiptID = importReceiptID;
            this.DateCreated = dateCreated;
            this.Total = total;
            this.StateAccept = stateAccept;
            this.EmployeeID = employeeID;
        }

        public string ImportReceiptID { get; set; }

        public string DateCreated { get; set; }

        public double Total { get; set; }

        public Boolean StateAccept { get; set; }

        public String EmployeeID { get; set; }
    }
}

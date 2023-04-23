using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ExportReceipt
    {
        public ExportReceipt(string exportReceiptID, string dateCreated, int total, bool stateAccept, string employeeID, List<ExportReceiptLine> exportReceiptLines)
        {
            this.ExportReceiptID = exportReceiptID;
            this.DateCreated = dateCreated;
            this.Total = total;
            this.StateAccept = stateAccept;
            this.EmployeeID = employeeID;
            this.ExportReceiptLines = exportReceiptLines;
        }

        public string ExportReceiptID { get; set; }

        public string DateCreated { get; set; }

        public int Total { get; set; }

        public Boolean StateAccept { get; set; }

        public String EmployeeID { get; set; }

        public List<ExportReceiptLine> ExportReceiptLines { get; set; }
    }
}

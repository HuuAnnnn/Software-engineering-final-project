using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ImportReceipt
    {
        public ImportReceipt(string importReceiptID, string dateCreated, int total, bool stateAccept)
        {
            this.ImportReceiptID = importReceiptID;
            this.DateCreated = dateCreated;
            this.Total = total;
            this.StateAccept = stateAccept;
        }

        public string ImportReceiptID { get; set; }

        public string DateCreated { get; set; }

        public int Total { get; set; }

        public Boolean StateAccept { get; set; }

    }
}

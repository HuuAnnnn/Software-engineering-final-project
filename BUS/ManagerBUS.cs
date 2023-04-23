using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ManagerBUS
    {
        public ManagerDAO managerDAO;

        public ManagerBUS() 
        {
            managerDAO = new ManagerDAO();
        }

        public DataTable selectReceiptInRangeDay(string startDate, string endDate)
        {
            return managerDAO.selectReceiptInRangeDay(startDate, endDate);
        }

        public DataTable selectAllReceipt()
        {
            return managerDAO.selectAllReceipt();
        }
        public DataTable selectReceiptSortTotal()
        {
            return managerDAO.selectReceiptSortTotal(); ;
        }

        public DataTable selectReceiptSortTotalDesc()
        {
            return managerDAO.selectReceiptSortTotalDesc();
        }

        public DataTable selectReceiptSortDateCreated()
        {
            return managerDAO.selectReceiptSortDateCreated();
        }

        public DataTable selectReceiptSortDateCreatedDesc()
        {
            return managerDAO.selectReceiptSortDateCreatedDesc();
        }
    }
}

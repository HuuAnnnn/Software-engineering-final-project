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
        public DataTable selectAllEmployee()
        {
            return managerDAO.selectAllEmployee();
        }

        public void deleteEmployee(string employeeID)
        {
            managerDAO.deleteEmployee(employeeID);
        }

        public DataTable selectEmployeeDesc()
        {
            return managerDAO.selectEmployeeDesc();
        }

        public int checkEmployeeID(string employeeID)
        {
            return managerDAO.checkEmployeeID(employeeID);
        }

        public void insertEmployeeQuery(string employeeID, string fullName, double salary, DateTime birthday, string sex, string phone, string address, byte[] avatar, int department, int isDeleted)
        {
            managerDAO.insertEmployeeQuery(employeeID, fullName, salary, birthday, sex, phone, address, avatar, department, isDeleted);
        }

        public void updateEmployeeQuery(string employeeID, string fullName, DateTime birthday, string sex, string phone, string address, byte[] avatar, int department)
        {
            managerDAO.updateEmployeeQuery(employeeID, fullName, birthday, sex, phone, address, avatar, department);
        }

        public void insertAccount(string username, string password, int timeChangePassword, string role)
        {
            managerDAO.insertAccount(username, password, timeChangePassword, role);
        }
    }
}

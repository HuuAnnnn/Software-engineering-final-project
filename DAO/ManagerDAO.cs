using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ManagerDAO
    {
        private Manager manager;

        public ManagerDAO() 
        {
            Connection.connect();
        }

        public DataTable selectAllReceipt()
        {
            string selectQuery = "SELECT DISTINCT Receipt.id, Receipt.dateCreate, Receipt.total, Customer.fullName, Employee.fullName as employeeName FROM Receipt, Customer, Employee WHERE Receipt.customerId = Customer.id AND Receipt.employeeID = Employee.EmployeeID";
            return Connection.selectQuery(selectQuery);
        }

        public DataTable selectReceiptInRangeDay(string startDate, string endDate)
        {
            string selectQuery = "SELECT DISTINCT t1.id, t1.dateCreate, t1.total, Customer.fullName, Employee.fullName as employeeName FROM (SELECT * FROM Receipt WHERE dateCreate BETWEEN '" + startDate + "' AND '" + endDate + "') as t1, Customer, Employee WHERE t1.customerId = Customer.id AND t1.employeeID = Employee.EmployeeID";
            return Connection.selectQuery(selectQuery);
        }

        public DataTable selectReceiptSortTotal()
        {
            string selectQuery = "SELECT DISTINCT Receipt.id, Receipt.dateCreate, Receipt.total, Customer.fullName, Employee.fullName as employeeName FROM Receipt, Customer, Employee WHERE Receipt.customerId = Customer.id AND Receipt.employeeID = Employee.EmployeeID ORDER BY Receipt.total";
            return Connection.selectQuery(selectQuery);
        }

        public DataTable selectReceiptSortTotalDesc()
        {
            string selectQuery = "SELECT DISTINCT Receipt.id, Receipt.dateCreate, Receipt.total, Customer.fullName, Employee.fullName as employeeName FROM Receipt, Customer, Employee WHERE Receipt.customerId = Customer.id AND Receipt.employeeID = Employee.EmployeeID ORDER BY Receipt.total Desc";
            return Connection.selectQuery(selectQuery);
        }

        public DataTable selectReceiptSortDateCreated()
        {
            string selectQuery = "SELECT DISTINCT Receipt.id, Receipt.dateCreate, Receipt.total, Customer.fullName, Employee.fullName as employeeName FROM Receipt, Customer, Employee WHERE Receipt.customerId = Customer.id AND Receipt.employeeID = Employee.EmployeeID ORDER BY Receipt.dateCreate";
            return Connection.selectQuery(selectQuery);
        }

        public DataTable selectReceiptSortDateCreatedDesc()
        {
            string selectQuery = "SELECT DISTINCT Receipt.id, Receipt.dateCreate, Receipt.total, Customer.fullName, Employee.fullName as employeeName FROM Receipt, Customer, Employee WHERE Receipt.customerId = Customer.id AND Receipt.employeeID = Employee.EmployeeID ORDER BY Receipt.dateCreate Desc";
            return Connection.selectQuery(selectQuery);
        }
    }
}

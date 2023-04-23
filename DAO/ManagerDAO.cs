using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

        public DataTable selectAllEmployee()
        {
            string selectQuery = "SELECT * FROM Employee WHERE isDeleted = 1";
            return Connection.selectQuery(selectQuery);
        }

        public void deleteEmployee(string employeeID)
        {
            string deleteQuery = "UPDATE Employee SET isDeleted = 0 WHERE employeeID = @val";
            SqlCommand command = new SqlCommand();
            command.CommandText = deleteQuery;
            command.Parameters.Add("@val", SqlDbType.NVarChar, 50);
            command.Parameters["@val"].Value = employeeID;
            Connection.actionQuery(command);
        }

        public DataTable selectEmployeeDesc()
        {
            string selectQuery = "SELECT employeeID FROM Employee ORDER BY employeeID DESC";
            return Connection.selectQuery(selectQuery);
        }

        public int checkEmployeeID(string employeeID)
        {
            string selectQuery = "SELECT * FROM Employee WHERE employeeID = '" + employeeID + "'";
            return Connection.selectQuery(selectQuery).Rows.Count;
        }

        public void insertEmployeeQuery(string employeeID, string fullName, double salary, DateTime birthday, string sex, string phone, string address, byte[] avatar, int department, int isDeleted)
        {
            string query = "INSERT INTO Employee VALUES (@val1, @val2, @val3, @val4, @val5, @val6, @val7, @val8, @val9, @val10)";
            SqlCommand command = new SqlCommand();
            command.CommandText = query;
            command.Parameters.Add("@val1", SqlDbType.NVarChar, 50);
            command.Parameters["@val1"].Value = employeeID;
            command.Parameters.Add("@val2", SqlDbType.NVarChar, 50);
            command.Parameters["@val2"].Value = fullName;
            command.Parameters.Add("@val3", SqlDbType.Int);
            command.Parameters["@val3"].Value = salary;
            command.Parameters.Add("@val4", SqlDbType.DateTime);
            command.Parameters["@val4"].Value = birthday;
            command.Parameters.Add("@val5", SqlDbType.NVarChar, 50);
            command.Parameters["@val5"].Value = sex;
            command.Parameters.Add("@val6", SqlDbType.NVarChar, 50);
            command.Parameters["@val6"].Value = phone;
            command.Parameters.Add("@val7", SqlDbType.NVarChar, 50);
            command.Parameters["@val7"].Value = address;
            command.Parameters.Add("@val8", SqlDbType.Image, int.MaxValue);
            command.Parameters["@val8"].Value = avatar;
            command.Parameters.Add("@val9", SqlDbType.Int);
            command.Parameters["@val9"].Value = department;
            command.Parameters.Add("@val10", SqlDbType.Int);
            command.Parameters["@val10"].Value = isDeleted;
            Connection.actionQuery(command);
        }

        public void updateEmployeeQuery(string employeeID, string fullName, DateTime birthday, string sex, string phone, string address, byte[] avatar, int department)
        {
            string query = "UPDATE Employee SET fullName = @val2, birthday = @val4, sex = @val5, phone = @val6, address = @val7, avatar = @val8, department = @val10 WHERE employeeID = @val1";
            SqlCommand command = new SqlCommand();
            command.CommandText = query;
            command.Parameters.Add("@val1", SqlDbType.NVarChar, 50);
            command.Parameters["@val1"].Value = employeeID;
            command.Parameters.Add("@val2", SqlDbType.NVarChar, 50);
            command.Parameters["@val2"].Value = fullName;
            command.Parameters.Add("@val4", SqlDbType.DateTime);
            command.Parameters["@val4"].Value = birthday;
            command.Parameters.Add("@val5", SqlDbType.NVarChar, 50);
            command.Parameters["@val5"].Value = sex;
            command.Parameters.Add("@val6", SqlDbType.NVarChar, 50);
            command.Parameters["@val6"].Value = phone;
            command.Parameters.Add("@val7", SqlDbType.NVarChar, 50);
            command.Parameters["@val7"].Value = address;
            command.Parameters.Add("@val8", SqlDbType.Image, int.MaxValue);
            command.Parameters["@val8"].Value = avatar;
            command.Parameters.Add("@val10", SqlDbType.Int);
            command.Parameters["@val10"].Value = department;
            Connection.actionQuery(command);
        }

        public void insertAccount(string username, string password, int timeChangePassword, string role) 
        {
            string query = "INSERT INTO Account VALUES (@val1, @val2, @val3, @val4)";
            SqlCommand command = new SqlCommand();
            command.CommandText = query;
            command.Parameters.Add("@val1", SqlDbType.NVarChar, 50);
            command.Parameters["@val1"].Value = username;
            command.Parameters.Add("@val2", SqlDbType.NVarChar, 255);
            command.Parameters["@val2"].Value = password;
            command.Parameters.Add("@val3", SqlDbType.Int);
            command.Parameters["@val3"].Value = timeChangePassword;
            command.Parameters.Add("@val4", SqlDbType.NVarChar, 50);
            command.Parameters["@val4"].Value = role;
            Connection.actionQuery(command);
        }
    }
}

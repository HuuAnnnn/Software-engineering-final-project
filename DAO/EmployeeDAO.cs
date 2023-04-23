using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class EmployeeDAO
    {
        Employee employee;

        public EmployeeDAO()
        {
            Connection.connect();
        }

        public EmployeeDAO(String employeeId, string fullName, double salary, string department, int isDeleted)
        {
            Connection.connect();
            employee = new Employee(employeeId, fullName, salary, department, isDeleted);
        }

        public Employee getEmployeeByID(string id)
        {
            String query = string.Format("SELECT employee.*, department.departmentName FROM EMPLOYEE, DEPARTMENT WHERE EMPLOYEEID = '{0}'", id);
            DataTable queryResult = Connection.selectQuery(query);
            Employee resultEmployee = null; ;
            if (queryResult.Rows.Count != 0)
            {
                foreach (DataRow row in queryResult.Rows)
                {
                    resultEmployee = new Employee(
                        row["employeeId"].ToString(),
                        row["fullName"].ToString(),
                        double.Parse(row["salary"].ToString()),
                        row["departmentName"].ToString(),
                        int.Parse(row["isDeleted"].ToString())
                    );
                }
            }

            return resultEmployee;
        }
    }
}

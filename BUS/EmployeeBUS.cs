using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class EmployeeBUS
    {
        private EmployeeDAO employeeDAO;
        public EmployeeBUS()
        {
            employeeDAO = new EmployeeDAO();
        }

        public EmployeeBUS(String employeeId, string fullName, double salary, string department, int isDeleted)
        {
            employeeDAO = new EmployeeDAO(employeeId, fullName, salary, department, isDeleted);
        }

        public Employee getEmployeeById(String id)
        {
            return employeeDAO.getEmployeeByID(id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Employee
    {
        public Employee(string employeeID, string fullName, int fee, int department)
        {
            this.EmployeeID = employeeID;
            this.FullName = fullName;
            this.Fee = fee;
            this.Department = department;
        }

        public string EmployeeID { get; set; }

        public string FullName { get; set; }

        public int Fee { get; set; }

        public int Department { get; set; }
    }
}

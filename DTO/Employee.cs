using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Employee
    {
        public Employee() { }

        public Employee(string employeeID, string fullName, double salary, string department, int isDeleted)
        {
            this.EmployeeID = employeeID;
            this.FullName = fullName;
            this.Salary = salary;
            this.Department = department;
            this.IsDeleted = isDeleted;
        }

        public string EmployeeID { get; set; }

        public string FullName { get; set; }

        public double Salary { get; set; }

        public string Department { get; set; }

        public int IsDeleted { get; set; }
    }
}

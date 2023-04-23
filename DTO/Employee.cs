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

        public Employee(string employeeID, string fullName, double salary, DateTime birthday, string sex, string phone, string address, byte[] avatar, string department, int isDeleted)
        {
            this.EmployeeID = employeeID;
            this.FullName = fullName;
            this.Salary = salary;
            this.Birthday = birthday;
            this.Sex = sex;
            this.Phone = phone;
            this.Address = address;
            this.Avatar = avatar;
            this.Department = department;
            this.IsDeleted = isDeleted;
        }

        public string EmployeeID { get; set; }

        public string FullName { get; set; }

        public double Salary { get; set; }

        public DateTime Birthday { get; set; }

        public string Sex { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public byte[] Avatar { get; set; }

        public string Department { get; set; }

        public int IsDeleted { get; set; }
    }
}

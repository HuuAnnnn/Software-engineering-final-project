using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Account
    {
        public Account(string employeeID, string password, int count, string role)
        {
            this.EmployeeID = employeeID;
            this.Password = password;
            this.Count = count;
            this.Role = role;
        }

        public string EmployeeID { get; set; }

        public string Password { get; set; }

        public int Count { get; set; }

        public string Role { get; set; }
    }
}

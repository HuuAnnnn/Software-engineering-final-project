using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Account
    {
        public Account(string employeeID, string password, int count)
        {
            this.EmployeeID = employeeID;
            this.Password = password;
            this.Count = count;
        }

        public string EmployeeID { get; set; }

        public string Password { get; set; }

        public int Count { get; set; }
    }
}

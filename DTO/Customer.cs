using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Customer
    {
        public Customer(string phone, string fullName, int point)
        {
            this.Phone= phone;
            this.FullName= fullName;
            this.Point= point;
        }

        public string Phone { get; set; }

        public string FullName { get; set; }

        public int Point { get; set; }
    }
}

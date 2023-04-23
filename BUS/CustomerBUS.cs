using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CustomerBUS
    {
        private CustomerDAO customerDao;

        public CustomerBUS()
        {
            customerDao = new CustomerDAO();
        }

        public CustomerBUS(string phone, string fullName)
        {
            customerDao = new CustomerDAO(phone, fullName);
        }

        public bool isExistsCustomer()
        {
            return customerDao.isCustomerExists();
        }

        public bool createNewUser()
        {
            return customerDao.insertNewCustomer();
        }
    }
}

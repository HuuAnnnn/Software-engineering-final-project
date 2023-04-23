using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CustomerBUS
    {
        private CustomerDAO customerDAO;

        public CustomerBUS()
        {
            customerDAO = new CustomerDAO();
        }

        public CustomerBUS(string phone, string fullName)
        {
            customerDAO = new CustomerDAO(phone, fullName);
        }

        public bool isExistsCustomer()
        {
            return customerDAO.isCustomerExists();
        }

        public bool createNewUser()
        {
            return customerDAO.insertNewCustomer();
        }

        public Customer getCustomerById(String id)
        {
            return customerDAO.getCustomerById(id);
        }

        public void udpateCustomerPoint(int point)
        {
            customerDAO.updatePoint(point);
        }
    }
}

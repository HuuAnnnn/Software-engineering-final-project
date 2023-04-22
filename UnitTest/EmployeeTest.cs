using BUS;
using DTO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        public void getEmployeeByIdWillReturnEmployee()
        {
            EmployeeBUS employeeBUS = new EmployeeBUS();
            Employee employee = employeeBUS.getEmployeeById("Test");
            Assert.IsNotNull(employee);
            Assert.AreEqual(employee.EmployeeID, "Test");
        }
    }
}

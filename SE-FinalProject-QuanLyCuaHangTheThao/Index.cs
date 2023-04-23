using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_FinalProject_QuanLyCuaHangTheThao
{
    public partial class Index : Form
    {
        private EmployeeBUS employeeBUS;
        public Index()
        {
            InitializeComponent();
            employeeBUS = new EmployeeBUS();

            Employee employee = employeeBUS.getEmployeeById(Program.curentAccount.EmployeeID);
            displayEmpUsername.Text = employee.FullName;
            displayEmplTitle.Text = employee.Department;
        }

        private void Index_Load(object sender, EventArgs e)
        {

        }
    }
}

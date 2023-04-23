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
    public partial class AccountSettingForm : Form
    {
        public AccountSettingForm()
        {
            InitializeComponent();
            EmployeeBUS employeeBUS = new EmployeeBUS();

            Employee employee = employeeBUS.getEmployeeById(Program.curentAccount.EmployeeID);
            displayEmpUsername.Text = employee.FullName;
            displayEmplTitle.Text = employee.Department;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Program.curentAccount = null;
                Application.Restart();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangePassword changePasswordForm = new ChangePassword();
            changePasswordForm.ShowDialog();
        }
    }
}

using BUS;
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
    public partial class CreateCustomer : Form
    {
        private bool isSaved = false;
        private CustomerBUS customerBus;
        public CreateCustomer()
        {
            InitializeComponent();
        }

        public bool getSaveState()
        {
            return isSaved;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string phoneNumber = inPhoneNumber.Text;
            string fullName = inUserFuillName.Text;
            customerBus = new CustomerBUS(phoneNumber, fullName);
            bool state = customerBus.createNewUser();
            if (state)
            {
                MessageBox.Show("Lưu thành công");
                isSaved = true;
                Dispose();
            } 
            else
            {
                MessageBox.Show("Lưu không thành công");
            }
        }
    }
}

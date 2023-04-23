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
    public partial class ChangePassword : Form
    {
        public bool isChangedPassword = false;
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult confirmResult = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnMaximumsize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult confirmResult = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void inPassword_Enter(object sender, EventArgs e)
        {
            if (inPassword.Text == ConfigGUI.DEFAULT_PLACEHOLDER_INPUT_NEW_PASSWORD)
            {
                inPassword.Text = "";
                inPassword.PasswordChar = '•';
                inPassword.ForeColor = Color.Black;
            }
        }

        private void inPassword_Leave(object sender, EventArgs e)
        {
            if (inPassword.Text == "")
            {
                inPassword.Text = ConfigGUI.DEFAULT_PLACEHOLDER_NEW_PASSWORD;
                inPassword.PasswordChar = '\0';
                inPassword.ForeColor = Color.DarkGray;
            }
        }

        private void inCurrentPassword_Enter(object sender, EventArgs e)
        {
            if (inCurrentPassword.Text == ConfigGUI.DEFAULT_PLACEHOLDER_INPUT_CURRENT_PASSWORD)
            {
                inCurrentPassword.Text = "";
                inCurrentPassword.PasswordChar = '•';
                inCurrentPassword.ForeColor = Color.Black;
            }
        }

        private void inCurrentPassword_Leave(object sender, EventArgs e)
        {
            if (inCurrentPassword.Text == "")
            {
                inCurrentPassword.Text = ConfigGUI.DEFAULT_PLACEHOLDER_INPUT_CURRENT_PASSWORD;
                inCurrentPassword.PasswordChar = '\0';
                inCurrentPassword.ForeColor = Color.DarkGray;
            }
        }

        private void inConfirmPassword_Enter(object sender, EventArgs e)
        {
            if (inConfirmPassword.Text == ConfigGUI.DEFAULT_PLACEHOLDER_INPUT_CONFIRM_PASSWORD)
            {
                inConfirmPassword.Text = "";
                inConfirmPassword.PasswordChar = '•';
                inConfirmPassword.ForeColor = Color.Black;
            }
        }

        private void inConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (inConfirmPassword.Text == "")
            {
                inConfirmPassword.Text = ConfigGUI.DEFAULT_PLACEHOLDER_INPUT_CONFIRM_PASSWORD;
                inConfirmPassword.PasswordChar = '\0';
                inConfirmPassword.ForeColor = Color.DarkGray;
            }
        }

        private void ChangePassword_MouseDown(object sender, MouseEventArgs e)
        {
            GUIUtils.ReleaseCapture();
            GUIUtils.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            changePassword();
        }


        public void changePassword()
        {
            string currentPassword = inCurrentPassword.Text;
            string password = inPassword.Text;
            string confirmPassword = inConfirmPassword.Text;

            if (currentPassword.Equals("") || password.Equals("") || confirmPassword.Equals("")
                || currentPassword.Equals(ConfigGUI.DEFAULT_PLACEHOLDER_INPUT_CURRENT_PASSWORD)
                || password.Equals(ConfigGUI.DEFAULT_PLACEHOLDER_INPUT_NEW_PASSWORD)
                || confirmPassword.Equals(ConfigGUI.DEFAULT_PLACEHOLDER_INPUT_CONFIRM_PASSWORD))
            {
                MessageBox.Show("Vui lòng không bỏ trống các trường");
                return;
            }

            if (!password.Equals(confirmPassword))
            {
                MessageBox.Show("Nhập lại mật khẩu không khớp");
                inConfirmPassword.ResetText();
                return;
            }

            string username = Program.curentAccount.EmployeeID;
            AccountBUS accountBUS = new AccountBUS(username, currentPassword);

            if (!accountBUS.isAuthenticationUser())
            {
                MessageBox.Show("Mật khẩu không chính xác");
                inPassword.ResetText();
                inCurrentPassword.ResetText();
                inConfirmPassword.ResetText();
            }
            else
            {
                bool isChangedAccount = accountBUS.changePassword(password);
                if (isChangedAccount)
                {
                    MessageBox.Show("Thay đổi mật khẩu thành công");
                    isChangedPassword = true;
                    Dispose();
                } 
                else
                {
                    MessageBox.Show("Thay đổi mật khẩu không thành công. Vui lòng thử lại");
                }
            }
        }
    }
}

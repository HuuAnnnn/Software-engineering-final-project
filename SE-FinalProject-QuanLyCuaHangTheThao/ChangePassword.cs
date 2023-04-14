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
            if (inPassword.Text == ConfigGUI.DEFAULT_PLACEHOLDER_INPUT_PASSWORD)
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
                inPassword.Text = ConfigGUI.DEFAULT_PLACEHOLDER_INPUT_PASSWORD;
                inPassword.PasswordChar = '\0';
                inPassword.ForeColor = Color.DarkGray;
            }
        }

        private void inUsername_Enter(object sender, EventArgs e)
        {
            if (inUsername.Text == ConfigGUI.DEFAULT_PLACEHOLDER_INPUT_USERNAME)
            {
                inUsername.Text = "";
                inUsername.ForeColor = Color.Black;
            }
        }

        private void inUsername_Leave(object sender, EventArgs e)
        {
            if (inUsername.Text == "")
            {
                inUsername.Text = ConfigGUI.DEFAULT_PLACEHOLDER_INPUT_USERNAME;
                inUsername.PasswordChar = '\0';
                inUsername.ForeColor = Color.DarkGray;
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
    }
}

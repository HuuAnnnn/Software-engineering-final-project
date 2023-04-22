using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SE_FinalProject_QuanLyCuaHangTheThao
{
    public partial class Login : Form
    {
        private AccountBUS accountBus;
        public Login()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            ActiveControl = lblWelcome;
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            GUIUtils.ReleaseCapture();
            GUIUtils.SendMessage(this.Handle, 0x112, 0xf012, 0);
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
                inUsername.ForeColor = Color.DarkGray;
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult confirmResult = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        public void login()
        {
            String username = inUsername.Text;
            String password = inPassword.Text;
            string hashPasword = Configuration.Config.hash(password);
            if (username.Equals(ConfigGUI.DEFAULT_PLACEHOLDER_INPUT_USERNAME) ||
                password.Equals(ConfigGUI.DEFAULT_PLACEHOLDER_INPUT_PASSWORD) ||
                username.Equals("") || password.Equals(""))
            {
                MessageBox.Show("Vui lòng không để trống username/password");
            }
            else
            {
                accountBus = new AccountBUS(username, hashPasword);
                if (!accountBus.isAuthUser())
                {
                    MessageBox.Show("Sai tài khoản/mật khẩu");
                } 
                else
                {
                    this.Dispose();
                    Home homepage = new Home();
                    homepage.Show();
                }
            }
        }

        private void inUsername_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }

        private void inPassword_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }
    }
}

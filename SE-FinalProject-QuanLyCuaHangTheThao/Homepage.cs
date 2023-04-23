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
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
            displayDatetime.Text = DateTime.Now.ToString("ddd, dd MMMM yyyy");
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            displayClock.Text = DateTime.Now.ToString("HH:MM:ss");
        }
    }
}

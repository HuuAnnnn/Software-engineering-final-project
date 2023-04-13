using SE_FinalProject_QuanLyCuaHangTheThao.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace SE_FinalProject_QuanLyCuaHangTheThao
{
    public partial class Home : Form
    {
        private Panel leftDisplayChooosePanel;
        private Button featureBtn;
        private string name;
        public Home()
        {
            InitializeComponent();
            const int LEFT_PANEL_WIDTH = 5;
            leftDisplayChooosePanel = new Panel();
            leftDisplayChooosePanel.Size = new Size(LEFT_PANEL_WIDTH, featHome.Height);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void button1_Click(object sender, EventArgs e)
        {
            activateFeature(sender, "home");
        }

        public void activateFeature(object feature, string featureName)
        {
            if (feature != null)
            {
                disableFeature();
                featureBtn = (Button)feature;
                featureBtn.BackColor = Color.White;
                featureBtn.ForeColor = Color.FromArgb(255, 147, 75);
                featureBtn.TextAlign = ContentAlignment.MiddleRight;
                name = featureName;
                string imageName = string.Format("{0}_active", featureName);
                System.Drawing.Image activeImage = readImageFromResource(imageName);
                featureBtn.Image = activeImage;
                featureBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                featureBtn.ImageAlign = ContentAlignment.MiddleCenter;
            }
        }

        private System.Drawing.Image readImageFromResource(string fileName)
        {
            ResourceManager rm = Resources.ResourceManager;
            Bitmap myImage = (Bitmap)rm.GetObject(fileName);

            return myImage;
        }

        public void disableFeature()
        {
            if (featureBtn != null)
            {
                featureBtn.BackColor = Color.OrangeRed;
                featureBtn.ForeColor = Color.White;
                featureBtn.TextAlign = ContentAlignment.MiddleCenter;

                string imageName = string.Format("{0}_normal", name);
                System.Drawing.Image activeImage = readImageFromResource(imageName);
                featureBtn.Image = activeImage;
                featureBtn.ImageAlign = ContentAlignment.MiddleLeft;
                featureBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void button3_Click(object sender, EventArgs e)
        {
            activateFeature(sender, "user");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            activateFeature(sender, "statistic");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            activateFeature(sender, "product");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            activateFeature(sender, "management");
        }
    }
}

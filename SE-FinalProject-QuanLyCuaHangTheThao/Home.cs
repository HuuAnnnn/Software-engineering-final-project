﻿using BUS;
using DTO;
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
//using static System.Net.Mime.MediaTypeNames;
namespace SE_FinalProject_QuanLyCuaHangTheThao
{
    public partial class Home : Form
    {
        private Panel leftDisplayChooosePanel;
        private Button featureBtn;
        private string name;
        private Form currentEmbedForm;
        private ReceiptBUS receiptBus;

        public Home()
        {
            InitializeComponent();
            Login loginPage = new Login();
            if (Program.curentAccount == null)
            {
                loginPage.ShowDialog();
                Program.curentAccount = loginPage.getAccount();
                if (Program.curentAccount != null)
                {
                    if (Program.curentAccount.Count == 0)
                    {
                        ChangePassword changePasswordForm = new ChangePassword();
                        changePasswordForm.ShowDialog();

                        if (!changePasswordForm.isChangedPassword)
                        {
                            System.Environment.Exit(1);
                        }
                    } 
                } 
                else
                {
                    System.Environment.Exit(1);
                }
            }
            loadHome();
        }

        private void loadHome()
        {
            receiptBus = new ReceiptBUS();
            const int LEFT_PANEL_WIDTH = 5;
            Program.currentReceipt = receiptBus.getCurrentReceipt();
            leftDisplayChooosePanel = new Panel();
            leftDisplayChooosePanel.Size = new Size(LEFT_PANEL_WIDTH, featHome.Height);
            featHome.Focus();

            if (!Program.curentAccount.Role.Equals("admin"))
            {
                btnManagement.Visible = false;
            }

            openEmbedForm(new Homepage());
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

        private void openEmbedForm(Form embedForm)
        {
            if (currentEmbedForm != null)
            {
                currentEmbedForm.Close();
            }

            currentEmbedForm = embedForm;
            embedForm.TopLevel = false;
            embedForm.TopMost = true;
            embedForm.FormBorderStyle = FormBorderStyle.None;
            embedForm.Dock = DockStyle.Fill;

            this.secondaryForm.Controls.Add(embedForm);
            this.secondaryForm.Tag = embedForm;
            this.Resize += secondaryForm_Resize;
            embedForm.BringToFront();
            embedForm.Show();
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
            GUIUtils.ReleaseCapture();
            GUIUtils.SendMessage(this.Handle, 0x112, 0xf012, 0);
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

        private void button1_Click(object sender, EventArgs e)
        {
            activateFeature(sender, "home");
            openEmbedForm(new Index());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            activateFeature(sender, "user");
            AccountSettingForm accountSettingForm = new AccountSettingForm();
            openEmbedForm(accountSettingForm);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            activateFeature(sender, "statistic");
            openEmbedForm(new StatisticForm());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            activateFeature(sender, "product");
            openEmbedForm(new ProductsForm());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            activateFeature(sender, "management");
            openEmbedForm(new Management());
        }

        private void featTrolley_Click(object sender, EventArgs e)
        {
            activateFeature(sender, "trolley");
            openEmbedForm(new CartForm());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openEmbedForm(new Homepage());
            disableFeature();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void secondaryForm_Resize(object sender, EventArgs e)
        {
            if (currentEmbedForm != null)
            {
                currentEmbedForm.Size = secondaryForm.ClientSize;
            }
        }

        private void featReceipt_Click(object sender, EventArgs e)
        {
            activateFeature(sender, "receipt");
            openEmbedForm(new Invoice());
        }
    }
}

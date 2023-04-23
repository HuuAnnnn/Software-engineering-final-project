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
    public partial class Management : Form
    {
        private ManagerBUS managerBUS;
        public Management()
        {
            InitializeComponent();
            managerBUS = new ManagerBUS();
            DataTable tableReceipt = managerBUS.selectAllReceipt();
            loadAllRecipt(tableReceipt);
        }

        public void loadAllRecipt(DataTable tableReceipt)
        {
            dgvReceipt.Rows.Clear();
            foreach (DataRow row in tableReceipt.Select())
            {
                int index = dgvReceipt.Rows.Add();
                dgvReceipt.Rows[index].Cells[0].Value = row["id"];
                dgvReceipt.Rows[index].Cells[1].Value = row["dateCreate"];
                dgvReceipt.Rows[index].Cells[2].Value = row["employeeName"];
                dgvReceipt.Rows[index].Cells[3].Value = row["fullName"];
                dgvReceipt.Rows[index].Cells[4].Value = row["total"];
            }
        }

        public void chooserSortType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chooserSortType.SelectedIndex.ToString() == "0")
            {
                DataTable tableReceipt = managerBUS.selectReceiptSortTotalDesc();
                loadAllRecipt(tableReceipt);
            }
            else if (chooserSortType.SelectedIndex.ToString() == "1")
            {
                DataTable tableReceipt = managerBUS.selectReceiptSortTotal();
                loadAllRecipt(tableReceipt);
            }
            else if (chooserSortType.SelectedIndex.ToString() == "2")
            {
                DataTable tableReceipt = managerBUS.selectReceiptSortDateCreatedDesc();
                loadAllRecipt(tableReceipt);
            }
            else
            {
                DataTable tableReceipt = managerBUS.selectReceiptSortDateCreated();
                loadAllRecipt(tableReceipt);
            }
        }
        public string formatDate(string date)
        {
            string[] timeArray = date.Split(' ');
            string[] dateArray = timeArray[0].Split('/');
            string day = dateArray[1];
            string month = dateArray[0];
            string year = dateArray[2];
            return year + "-" + month + "-" + day;
        }

        private void btnSearchReceipt_Click(object sender, EventArgs e)
        {
            string startDate = formatDate(dtpStart.Value.ToString());
            string endDate = formatDate(dtpEnd.Value.ToString());
            MessageBox.Show(startDate);
            MessageBox.Show(endDate);
            DataTable tableReceipt = managerBUS.selectReceiptInRangeDay(startDate, endDate);
            loadAllRecipt(tableReceipt);
        }
    }
}

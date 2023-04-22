using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_FinalProject_QuanLyCuaHangTheThao
{
    public partial class Invoice : Form
    {
        EmployeeBUS employeeBus;
        public Invoice()
        {
            InitializeComponent();
            employeeBus = new EmployeeBUS();

            customerInfo.Text = "";
            displayDate.Text = "";
            displayInvoiceID.Text = "123345";
            displayEmployeeInfo.Text = employeeBus.getEmployeeById(Program.curentAccount.EmployeeID).FullName;
            displayDiscount.Text = "";
            displayTotalPrice.Text = "";
            displayFinalTotalPrice.Text = "";
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            printDocument1.DefaultPageSettings.PaperSize = new PaperSize("A4", 827, 1169);
            printDocument1.DefaultPageSettings.PrinterResolution = new PrinterResolution { X = 100, Y = 100 };
            printDocument1.DocumentName = displayInvoiceID.Text;
            printDocument1.PrinterSettings.PrinterName = displayInvoiceID.Text;

            printDialog1.Document = printDocument1;
            printDialog1.PrinterSettings.PrintFileName = displayInvoiceID.Text;

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Save As PDF";
                sfd.Filter = "(*.pdf)|*.pdf";
                sfd.InitialDirectory = @"C:\";
                sfd.FileName = displayInvoiceID.Text;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.PrinterSettings.PrintFileName = sfd.FileName;
                    printDocument1.Print();
                }
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("CỬA HÀNG BÁN DỤNG CỤ THỂ THAO", new Font("Quick Sand", 16, FontStyle.Bold), Brushes.Black, new Point(230, 15));
            e.Graphics.DrawString("HÓA ĐƠN", new Font("Quick Sand", 16, FontStyle.Bold), Brushes.Black, new Point(375, 71));
            e.Graphics.DrawString("Số hóa đơn: " + displayInvoiceID.Text, new Font("Quick Sand", 16, FontStyle.Regular), Brushes.Black, new Point(10, 115));
            e.Graphics.DrawString("Khách hàng: " + customerInfo.Text, new Font("Quick Sand", 16, FontStyle.Regular), Brushes.Black, new Point(10, 156));
            e.Graphics.DrawString("Nhân viên: " + displayEmployeeInfo.Text, new Font("Quick Sand", 16, FontStyle.Regular), Brushes.Black, new Point(596, 115));
            e.Graphics.DrawString("Ngày lập: " + displayDate.Text, new Font("Quick Sand", 16, FontStyle.Regular), Brushes.Black, new Point(596, 156));

            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------", new Font("Quick Sand", 16, FontStyle.Regular), Brushes.Black, new Point(10, 190));
            e.Graphics.DrawString("Tên sản phẩm", new Font("Quick Sand", 12, FontStyle.Bold), Brushes.Black, new Point(10, 217));
            e.Graphics.DrawString("Số lượng", new Font("Quick Sand", 12, FontStyle.Bold), Brushes.Black, new Point(451, 217));
            e.Graphics.DrawString("Đơn giá", new Font("Quick Sand", 12, FontStyle.Bold), Brushes.Black, new Point(597, 217));
            e.Graphics.DrawString("Thành tiền", new Font("Quick Sand", 12, FontStyle.Bold), Brushes.Black, new Point(719, 217));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------", new Font("Quick Sand", 16, FontStyle.Regular), Brushes.Black, new Point(10, 238));
            int currentPointer = 268;
            int i = 0;
            if (dgvOrderDetails.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvOrderDetails.Rows)
                {   
                    if (row.Cells[0].Value != null)
                    {
                        e.Graphics.DrawString(row.Cells[0].Value.ToString().ToString(), new Font("Quick Sand", 12, FontStyle.Regular), Brushes.Black, new Point(10, currentPointer));
                        e.Graphics.DrawString(row.Cells[1].Value.ToString(), new Font("Quick Sand", 12, FontStyle.Regular), Brushes.Black, new Point(451, currentPointer));
                        e.Graphics.DrawString(row.Cells[2].Value.ToString(), new Font("Quick Sand", 12, FontStyle.Regular), Brushes.Black, new Point(597, currentPointer));
                        e.Graphics.DrawString(row.Cells[3].Value.ToString(), new Font("Quick Sand", 12, FontStyle.Regular), Brushes.Black, new Point(719, currentPointer));
                        e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------------------------------", new Font("Quick Sand", 11, FontStyle.Regular), Brushes.Black, new Point(10, currentPointer + 15));
                        currentPointer = 268 + i * 30;
                        i++;
                    }
                }

            }
            e.Graphics.DrawString("Tổng tiền: ", new Font("Quick Sand", 12, FontStyle.Bold), Brushes.Black, new Point(535, currentPointer + 20));
            e.Graphics.DrawString("Giảm giá: ", new Font("Quick Sand", 12, FontStyle.Bold), Brushes.Black, new Point(535, currentPointer + 40));
            e.Graphics.DrawString("-------------------------------------------------------------------------------------", new Font("Quick Sand", 11, FontStyle.Regular), Brushes.Black, new Point(535, currentPointer + 60));
            e.Graphics.DrawString("Tổng thanh toán: ", new Font("Quick Sand", 12, FontStyle.Bold), Brushes.Black, new Point(535, currentPointer + 80));

            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------------------------------", new Font("Quick Sand", 11, FontStyle.Regular), Brushes.Black, new Point(10, currentPointer + 150));
            e.Graphics.DrawString("Xin cảm hơn và hẹn gặp lại quý khách", new Font("Quick Sand", 12, FontStyle.Italic), Brushes.Black, new Point(290, currentPointer + 200));
        }
    }
}


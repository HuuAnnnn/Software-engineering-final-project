using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_FinalProject_QuanLyCuaHangTheThao
{
    public partial class Invoice : Form
    {
        EmployeeBUS employeeBus;
        ReceiptBUS receiptBUS;
        public Invoice()
        {
            InitializeComponent();
            employeeBus = new EmployeeBUS();
            receiptBUS = new ReceiptBUS();
            btnCheckout.Enabled = false;

            customerInfo.Text = "";
            displayDate.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            displayInvoiceID.Text = receiptBUS.generateInvoiceID();
            displayEmployeeInfo.Text = employeeBus.getEmployeeById(Program.curentAccount.EmployeeID).FullName;
            displayDiscount.Text = "";
            displayTotalPrice.Text = "";
            displayFinalTotalPrice.Text = "";
            loadInvoice();
        }

        public void loadInvoice()
        {
            ProductBUS productBus = new ProductBUS();
            Product product = null;
            double totalPrice = 0;

            foreach (string key in Program.cart.Keys)
            {
                product = productBus.getProductByID(key);
                totalPrice += Program.cart[key] * product.Price;
                dgvOrderDetails.Rows.Add(product.ProductName,
                                        Program.cart[key],
                                        product.Price,
                                        Program.cart[key] * product.Price);
            }
            displayTotalPrice.Text = GUIUtils.convertIntoVND(totalPrice);
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
                sfd.DefaultExt = "*.pdf";
                sfd.Filter = "Portable Document Format|*.pdf";
                sfd.Title = "Save an Invoice";
                sfd.FileName = displayInvoiceID.Text;
                DialogResult result = sfd.ShowDialog();

                if (result != DialogResult.Cancel)
                {
                    printDocument1.PrinterSettings.PrintToFile = true;
                    printDocument1.PrinterSettings.PrintFileName = sfd.FileName;
                    printDocument1.Print();
                }

                MessageBox.Show("Thanh toán thành công");

                customerInfo.Clear();
                if (dgvOrderDetails.Rows.Count > 1)
                {
                    for (int i = 0; i < dgvOrderDetails.Rows.Count; i++)
                    {
                        dgvOrderDetails.Rows.RemoveAt(i);
                    }
                }
                displayDate.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                displayInvoiceID.Text = receiptBUS.generateInvoiceID();
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("CỬA HÀNG BÁN DỤNG CỤ THỂ THAO", new Font("Quick Sand", 16, FontStyle.Bold), Brushes.Black, new Point(230, 15));
            e.Graphics.DrawString("HÓA ĐƠN", new Font("Quick Sand", 16, FontStyle.Bold), Brushes.Black, new Point(375, 71));
            e.Graphics.DrawString("Số hóa đơn: " + displayInvoiceID.Text, new Font("Quick Sand", 14, FontStyle.Regular), Brushes.Black, new Point(10, 115));
            e.Graphics.DrawString("Khách hàng: " + customerInfo.Text, new Font("Quick Sand", 14, FontStyle.Regular), Brushes.Black, new Point(10, 156));
            e.Graphics.DrawString("Nhân viên: " + displayEmployeeInfo.Text, new Font("Quick Sand", 14, FontStyle.Regular), Brushes.Black, new Point(566, 115));
            e.Graphics.DrawString("Ngày lập: " + displayDate.Text, new Font("Quick Sand", 14, FontStyle.Regular), Brushes.Black, new Point(566, 156));

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
                        e.Graphics.DrawString(row.Cells[0].Value.ToString(), new Font("Quick Sand", 12, FontStyle.Regular), Brushes.Black, new Point(10, currentPointer));
                        e.Graphics.DrawString(row.Cells[1].Value.ToString(), new Font("Quick Sand", 12, FontStyle.Regular), Brushes.Black, new Point(471, currentPointer));
                        e.Graphics.DrawString(row.Cells[2].Value.ToString(), new Font("Quick Sand", 12, FontStyle.Regular), Brushes.Black, new Point(607, currentPointer));
                        e.Graphics.DrawString(row.Cells[3].Value.ToString(), new Font("Quick Sand", 12, FontStyle.Regular), Brushes.Black, new Point(729, currentPointer));
                        e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------------------------------", new Font("Quick Sand", 11, FontStyle.Regular), Brushes.Black, new Point(10, currentPointer + 20));
                        i++;
                        currentPointer = 268 + i * 35;
                    }
                }

            }
            e.Graphics.DrawString("Tổng tiền: ", new Font("Quick Sand", 12, FontStyle.Bold), Brushes.Black, new Point(535, currentPointer + 50));
            e.Graphics.DrawString("Giảm giá: ", new Font("Quick Sand", 12, FontStyle.Bold), Brushes.Black, new Point(535, currentPointer + 70));
            e.Graphics.DrawString("--------------------------------------------------------", new Font("Quick Sand", 11, FontStyle.Regular), Brushes.Black, new Point(535, currentPointer + 90));
            e.Graphics.DrawString("Tổng thanh toán: ", new Font("Quick Sand", 12, FontStyle.Bold), Brushes.Black, new Point(535, currentPointer + 120));

            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------------------------------", new Font("Quick Sand", 11, FontStyle.Regular), Brushes.Black, new Point(10, currentPointer + 150));
            e.Graphics.DrawString("Xin cảm hơn và hẹn gặp lại quý khách", new Font("Quick Sand", 12, FontStyle.Italic), Brushes.Black, new Point(290, currentPointer + 200));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.currentReceipt = null;
            Program.cart = new Dictionary<string, int>();
            if (dgvOrderDetails.Rows.Count > 1)
            {
                for (int i = 0; i < dgvOrderDetails.Rows.Count; i++)
                {
                    dgvOrderDetails.Rows.RemoveAt(i);
                }
            }
        }

        private void btnCustomerCheck_Click(object sender, EventArgs e)
        {
            string phoneNumber = customerInfo.Text;
            CustomerBUS customerBus = new CustomerBUS(phoneNumber, "");
            if (!customerBus.isExistsCustomer())
            {
                CreateCustomer createCustomer = new CreateCustomer();
                createCustomer.ShowDialog();
                if (createCustomer.getSaveState())
                {
                    customerInfo.ReadOnly = true;
                    btnCheckout.Enabled = true;
                }
            }
            else
            {
                customerInfo.ReadOnly = true;
                btnCheckout.Enabled = true;
            }

        }
    }
}
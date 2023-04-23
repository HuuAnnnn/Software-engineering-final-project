using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_FinalProject_QuanLyCuaHangTheThao
{
    public partial class Management : Form
    {
        private ManagerBUS managerBUS;
        private string productFileName;
        private ImportReceipt importReceipt;
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Choose Product iamge";

            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
            string sep = string.Empty;

            foreach (var c in codecs)
            {
                string codecName = c.CodecName.Substring(8).Replace("Codec", "Files").Trim();
                openFileDialog.Filter = String.Format("{0}{1}{2} ({3})|{3}", openFileDialog.Filter, sep, codecName, c.FilenameExtension);
                sep = "|";
            }

            openFileDialog.Filter = String.Format("{0}{1}{2} ({3})|{3}", openFileDialog.Filter, sep, "All Files", "*.*");
            openFileDialog.DefaultExt = ".jpg";

            DialogResult result = openFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                productFileName = openFileDialog.FileName;
                displayProductImage.Image = Image.FromFile(productFileName); 
            }
        }

        public byte[] convertImageToByteArray(string fileName)
        {
            FileStream fileStream;
            BinaryReader binaryReader;
            byte[] byteArray;

            if (!File.Exists(fileName))
            {
                return null;
            }

            fileStream = new FileStream(fileName, FileMode.Open);
            binaryReader = new BinaryReader(fileStream);
            byteArray = new byte[fileStream.Length];
            byteArray = binaryReader.ReadBytes(Convert.ToInt32((fileStream.Length)));

            binaryReader.Close();
            fileStream.Close();
            return byteArray;
        }

        public Image convertByteArrayToImage(byte[] byteArray)
        {
            return (Bitmap)((new ImageConverter()).ConvertFrom(byteArray));
        }


        private void btnInsertProduct_Click(object sender, EventArgs e)
        {
            if (inProductName.Text.Equals("") || inProductPrice.Text.Equals("") || cbProductCategory.Text.Equals("") || inProductAmount.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng không để trống các trường");
                return;
            }
            string productName = inProductName.Text;
            double productPrice = double.Parse(inProductPrice.Text);
            string category = cbProductCategory.Text;
            int amount = int.Parse(inProductAmount.Text);
            string productId = ((dgvDisplayNewProduct.Rows.Count) + "").PadLeft(3, '0');

            dgvDisplayNewProduct.Rows.Add(productId, productName, productPrice, amount, category, productFileName);
            
            inProductName.ResetText();
            inProductPrice.ResetText();
            inProductAmount.ResetText();
            displayProductImage.Image = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double total = 0;
            foreach (DataGridViewRow row in dgvDisplayNewProduct.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    total += double.Parse(row.Cells[2].Value.ToString()) * double.Parse(row.Cells[3].Value.ToString());
                }
            }

            ProductBUS productBus = null;
            ImportReceiptBUS importReceiptBus = new ImportReceiptBUS(DateTime.Now.ToString("yyyy-MM-dd"), total, true, Program.curentAccount.EmployeeID);
            importReceiptBus.createNewReceipt();
            importReceipt = importReceiptBus.getImportReceipt();
            ImportLineReceiptLineBUS importLineReceiptBus = null;

            foreach(DataGridViewRow row in dgvDisplayNewProduct.Rows)
            {
                if (row.Cells[0].Value == null)
                {
                    continue;
                }

                ImageConverter _imageConverter = new ImageConverter();
                Image image = Image.FromFile(row.Cells[5].Value.ToString());
                byte[] xByte = null;
                if (image != null)
                {
                    xByte = (byte[])_imageConverter.ConvertTo(image, typeof(byte[]));
                }

                productBus = new ProductBUS(
                    row.Cells[1].Value.ToString(),
                    int.Parse(row.Cells[3].Value.ToString()),
                    int.Parse(row.Cells[3].Value.ToString()),
                    row.Cells[4].Value.ToString(),
                    double.Parse(row.Cells[2].Value.ToString()),
                    xByte
                 );

                productBus.insertQuery();
                Product product = productBus.getProduct();
                double unitToalPrice = int.Parse(row.Cells[3].Value.ToString()) * double.Parse(row.Cells[2].Value.ToString());
                importLineReceiptBus = new ImportLineReceiptLineBUS(importReceipt.ImportReceiptID, product.ProductId, int.Parse(row.Cells[3].Value.ToString()), unitToalPrice);
                importLineReceiptBus.insertImportReceiptLine();
            }

            printDocument1.DefaultPageSettings.PaperSize = new PaperSize("A4", 827, 1169);
            printDocument1.DefaultPageSettings.PrinterResolution = new PrinterResolution { X = 100, Y = 100 };
            printDocument1.DocumentName = importReceipt.ImportReceiptID;
            printDocument1.PrinterSettings.PrinterName = importReceipt.ImportReceiptID;

            printDialog1.Document = printDocument1;
            printDialog1.PrinterSettings.PrintFileName = importReceipt.ImportReceiptID;

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.DefaultExt = "*.pdf";
                sfd.Filter = "Portable Document Format|*.pdf";
                sfd.Title = "Save an Invoice";
                sfd.FileName = importReceipt.ImportReceiptID;
                DialogResult result = sfd.ShowDialog();

                if (result != DialogResult.Cancel)
                {
                    printDocument1.PrinterSettings.PrintToFile = true;
                    printDocument1.PrinterSettings.PrintFileName = sfd.FileName;
                    printDocument1.Print();
                }
            }

            MessageBox.Show("Thêm các sản phẩm thành công");
            dgvDisplayNewProduct.Rows.Clear();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("CỬA HÀNG BÁN DỤNG CỤ THỂ THAO", new Font("Quick Sand", 16, FontStyle.Bold), Brushes.Black, new Point(230, 15));
            e.Graphics.DrawString("PHIẾU NHẬP HÀNG", new Font("Quick Sand", 16, FontStyle.Bold), Brushes.Black, new Point(304, 71));
            e.Graphics.DrawString("Số phiếu nhập: " + importReceipt.ImportReceiptID, new Font("Quick Sand", 14, FontStyle.Regular), Brushes.Black, new Point(10, 115));
            e.Graphics.DrawString("Nhân viên: " + Program.curentAccount.EmployeeID, new Font("Quick Sand", 14, FontStyle.Regular), Brushes.Black, new Point(566, 115));
            e.Graphics.DrawString("Ngày lập: " + DateTime.Today.ToString("dd-MM-yyyy"), new Font("Quick Sand", 14, FontStyle.Regular), Brushes.Black, new Point(566, 156));

            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------", new Font("Quick Sand", 16, FontStyle.Regular), Brushes.Black, new Point(10, 190));
            e.Graphics.DrawString("Tên sản phẩm", new Font("Quick Sand", 12, FontStyle.Bold), Brushes.Black, new Point(10, 217));
            e.Graphics.DrawString("Số lượng", new Font("Quick Sand", 12, FontStyle.Bold), Brushes.Black, new Point(451, 217));
            e.Graphics.DrawString("Đơn giá", new Font("Quick Sand", 12, FontStyle.Bold), Brushes.Black, new Point(597, 217));
            e.Graphics.DrawString("Loại", new Font("Quick Sand", 12, FontStyle.Bold), Brushes.Black, new Point(719, 217));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------", new Font("Quick Sand", 16, FontStyle.Regular), Brushes.Black, new Point(10, 238));
            int currentPointer = 268;
            int i = 0;
            if (dgvDisplayNewProduct.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvDisplayNewProduct.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        e.Graphics.DrawString(row.Cells[1].Value.ToString(), new Font("Quick Sand", 12, FontStyle.Regular), Brushes.Black, new Point(10, currentPointer));
                        e.Graphics.DrawString(row.Cells[3].Value.ToString(), new Font("Quick Sand", 12, FontStyle.Regular), Brushes.Black, new Point(471, currentPointer));
                        e.Graphics.DrawString(row.Cells[2].Value.ToString(), new Font("Quick Sand", 12, FontStyle.Regular), Brushes.Black, new Point(607, currentPointer));
                        e.Graphics.DrawString(row.Cells[4].Value.ToString(), new Font("Quick Sand", 12, FontStyle.Regular), Brushes.Black, new Point(729, currentPointer));
                        e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------------------------------", new Font("Quick Sand", 11, FontStyle.Regular), Brushes.Black, new Point(10, currentPointer + 20));
                        i++;
                        currentPointer = 268 + i * 35;
                    }
                }

            }
        }
    }
}

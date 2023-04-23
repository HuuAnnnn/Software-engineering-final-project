using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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
            ImportReceipt importReceipt = importReceiptBus.getImportReceipt();
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

                MessageBox.Show("Thêm các sản phẩm thành công");
                dgvDisplayNewProduct.Rows.Clear();
            }
        }
    }
}

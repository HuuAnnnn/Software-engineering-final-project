using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SE_FinalProject_QuanLyCuaHangTheThao
{
    public partial class ProductsForm : Form
    {
        private ProductBUS productBUS;
        private ReceiptBUS receiptBUS;
        public ProductsForm()
        {
            InitializeComponent();
            displayLimitPriceRange.Text = GUIUtils.convertIntoVND(ConfigGUI.DEFAULT_LIMIT_PRICE);
            priceRange.Value = ConfigGUI.DEFAULT_LIMIT_PRICE;
            priceRange.Maximum = ConfigGUI.DEFAULT_LIMIT_PRICE;

            productBUS = new ProductBUS();
            receiptBUS = new ReceiptBUS();
            addProducts(productBUS.selectQuery());
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
        }

        private void priceRange_Scroll(object sender, EventArgs e)
        {
            displayLimitPriceRange.Text = GUIUtils.convertIntoVND(priceRange.Value);
        }

        public void clearDisplayProducts()
        {
            displayProducts.Controls.Clear();
        }
        private void displayLimitPriceRange_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int oldValue = priceRange.Value;
                try
                {
                    decimal decval;
                    string inputAmountInCurrencyForm = displayLimitPriceRange.Text;

                    // if user input like 100,000,000 then we must convert it by currency
                    if (inputAmountInCurrencyForm.Contains(",")) {
                        bool convt = decimal.TryParse(inputAmountInCurrencyForm,
                                                    NumberStyles.Currency,
                                                    CultureInfo.GetCultureInfo("vn-VN").NumberFormat,
                                                    out decval);
                    } else
                    {
                        decval = Convert.ToDecimal(inputAmountInCurrencyForm);
                    }

                    priceRange.Value = Convert.ToInt32(decval);
                    displayLimitPriceRange.Text = GUIUtils.convertIntoVND(priceRange.Value);
                }
                catch
                {
                    MessageBox.Show("Nhập sai định dạng, vui lòng nhập lại");
                    priceRange.Value = oldValue;
                }
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

        public void addProducts(DataTable dataTableProduct)
        {
            Panel cardProduct = null;
            displayProducts.Margin = new Padding(10);

            string productName = "";
            string price = "";
            Image image = null;
            foreach(DataRow row in dataTableProduct.Select())
            {
                productName = row["productName"].ToString();
                price = row["price"].ToString();
                image = convertByteArrayToImage((byte[])row["photo"]);
                cardProduct = createProductCard(productName, price, image);
                cardProduct.Margin = new Padding(10);
                displayProducts.Controls.Add(cardProduct);
            }
        }

        public Panel createProductCard(string productName, string price, Image image)
        {
            // main body of product frame
            Panel cardBody = new Panel();
            cardBody.Size = new Size(193, 297);
            cardBody.BackColor = Color.White;
            cardBody.BorderStyle = BorderStyle.FixedSingle;

            // product image
            PictureBox cardImage = new PictureBox();
            cardImage.Image = image;
            cardImage.Size = new Size(193, 193);
            cardImage.SizeMode = PictureBoxSizeMode.StretchImage;
            cardImage.Location = new Point(-1, -1);
            cardImage.BorderStyle = BorderStyle.FixedSingle;
            cardBody.Controls.Add(cardImage);

            // title of product frame
            Label cardTitle = new Label();
            cardTitle.Size = new Size(189, 66);
            cardTitle.Text = productName;
            cardTitle.BackColor = Color.White;
            cardTitle.Font = new Font("Quicksand", 12, FontStyle.Bold);
            cardTitle.Location = new Point(0, 195);
            cardBody.Controls.Add(cardTitle);

            // product's price
            Label productPrice = new Label();
            productPrice.Text = price;
            productPrice.Size = new Size(155, 36);
            productPrice.BackColor = Color.OrangeRed;
            productPrice.Font = new Font("Quicksand", 12, FontStyle.Bold);
            productPrice.TextAlign = ContentAlignment.MiddleCenter;
            productPrice.ForeColor = Color.White;
            productPrice.Location = new Point(0, 259);
            cardBody.Controls.Add(productPrice);

            // add to cart button
            Label btnAddToCart = new Label();
            btnAddToCart.Size = new Size(40, 36);
            btnAddToCart.Location = new Point(152, 259);
            btnAddToCart.Image = Properties.Resources.cart;
            btnAddToCart.BackColor = Color.Gainsboro;
            btnAddToCart.Cursor = Cursors.Hand;
            cardBody.Controls.Add(btnAddToCart);
            btnAddToCart.Click += btnAddToCart_Click;

            return cardBody;
        }

        private void btnAddToCart_Click (object sender, EventArgs e)
        {
            if (Program.currentReceipt == null)
            {
                receiptBUS = new ReceiptBUS(DateTime.Now.ToString("yyyy-mm-dd"), 0, Program.curentAccount.EmployeeID, "");
                receiptBUS.createNewReceipt();
                Program.currentReceipt = receiptBUS.getReceipt();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string productName = inProductSearch.Text;
            string priceVND = displayLimitPriceRange.Text;
            priceVND = priceVND.Substring(1, priceVND.Length - 4).Trim();
            string[] priceVNDArray = priceVND.Split(',');
            string priceFormated = "";
            foreach(string priceElement in priceVNDArray)
            {
                priceFormated += priceElement;
            }
            int price = Convert.ToInt32(priceFormated);
            DataTable productFound = findProductWithNameAndPrice(productName, price);
            clearDisplayProducts();
            addProducts(productFound);
        }

        public DataTable findProductWithNameAndPrice(string productName, int price)
        {
            return productBUS.selectQueryWithNameAndPrice(productName, price);
        }

        private void chooseSortType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chooseSortType.SelectedIndex.ToString() == "0")
            {
                clearDisplayProducts();
                addProducts(productBUS.selectSortPriceDesc());
            }
            else
            {
                clearDisplayProducts();
                addProducts(productBUS.selectSortPrice());
            }
        }

        private void chooseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(chooseType.SelectedItem.ToString());
            string category = chooseType.SelectedItem.ToString().Trim();
            clearDisplayProducts();
            addProducts(productBUS.filterProductWithCategory(category));
        }
    }
}

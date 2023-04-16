using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_FinalProject_QuanLyCuaHangTheThao
{
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
            displayLimitPriceRange.Text = GUIUtils.convertIntoVND(ConfigGUI.DEFAULT_LIMIT_PRICE);
            priceRange.Value = ConfigGUI.DEFAULT_LIMIT_PRICE;
            priceRange.Maximum = ConfigGUI.DEFAULT_LIMIT_PRICE;
            addProducts();
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            
        }

        private void priceRange_Scroll(object sender, EventArgs e)
        {
            displayLimitPriceRange.Text = GUIUtils.convertIntoVND(priceRange.Value);
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

        public void addProducts()
        {
            Panel cardProduct = null;
            displayProducts.Margin = new Padding(10);
            for (int i = 0; i < 100; i++)
            {
                cardProduct = createProductCard();
                cardProduct.Margin = new Padding(10);
                displayProducts.Controls.Add(cardProduct);
            }
        }

        public Panel createProductCard()
        {
            // main body of product frame
            Panel cardBody = new Panel();
            cardBody.Size = new Size(193, 297);
            cardBody.BackColor = Color.White;
            cardBody.BorderStyle = BorderStyle.FixedSingle;

            // product image
            PictureBox cardImage = new PictureBox();
            cardImage.Image = Properties.Resources.mockup_image;
            cardImage.Size = new Size(193, 193);
            cardImage.SizeMode = PictureBoxSizeMode.StretchImage;
            cardImage.Location = new Point(-1, -1);
            cardImage.BorderStyle = BorderStyle.FixedSingle;
            cardBody.Controls.Add(cardImage);

            // title of product frame
            Label cardTitle = new Label();
            cardTitle.Size = new Size(189, 66);
            cardTitle.Text = "Lều cắm trại Lều cắm trại Lều cắm trại Lều cắm trại";
            cardTitle.BackColor = Color.White;
            cardTitle.Font = new Font("Quicksand", 12, FontStyle.Bold);
            cardTitle.Location = new Point(0, 195);
            cardBody.Controls.Add(cardTitle);

            // product's price
            Label productPrice = new Label();
            productPrice.Text = "10,000,000 VNĐ";
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

            return cardBody;
        }
    }
}

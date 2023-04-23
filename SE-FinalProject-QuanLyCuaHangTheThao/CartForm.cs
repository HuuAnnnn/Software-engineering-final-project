using BUS;
using DTO;
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
    public partial class CartForm : Form
    {
        public CartForm()
        {
            InitializeComponent();
            ProductBUS productBus = new ProductBUS();
            Product product = null;
            double totalPrice = 0;
            foreach (string key in Program.cart.Keys)
            {
                product = productBus.getProductByID(key);
                totalPrice += Program.cart[key] * product.Price;
                displayCart.Rows.Add(product.ProductId,
                                        product.ProductName,
                                        Program.cart[key],
                                        product.Price,
                                        Program.cart[key] * product.Price);
            }
            displayTotalPrice.Text = GUIUtils.convertIntoVND(totalPrice);
        }

        private void displayCart_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string productID;
            int productAmount;
            double productPrice;
            double totalPrice = 0;
            foreach (DataGridViewRow row in displayCart.Rows)
            {
                if (row.Cells[0].Value != null )
                {
                    productID = row.Cells[0].Value.ToString();
                    productAmount = int.Parse(row.Cells[2].Value.ToString());
                    productPrice = double.Parse(row.Cells[3].Value.ToString());

                    row.Cells[4].Value = productPrice * productAmount;
                    totalPrice += double.Parse(row.Cells[4].Value.ToString());
                    Program.cart[productID] = productAmount;
                }
            }

            displayTotalPrice.Text = GUIUtils.convertIntoVND(totalPrice);
        }

        private void displayCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string productName = displayCart.Rows[e.RowIndex].Cells[1].Value.ToString();
            DialogResult confirmResult = MessageBox.Show(string.Format("Bạn có chắc chắn muốn xóa sản phẩm {0} khỏi giỏ hàng?", productName), 
                                                        "Thông báo", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                string productId = displayCart.Rows[e.RowIndex].Cells[0].Value.ToString();
                double productPrice = double.Parse(displayCart.Rows[e.RowIndex].Cells[4].Value.ToString());
                displayCart.Rows.Remove(displayCart.Rows[e.RowIndex]);
                Program.cart.Remove(productId);

                double totalPrice = double.Parse(displayTotalPrice.Text.ToString().Substring(1).Trim()) - productPrice;
                displayTotalPrice.Text = GUIUtils.convertIntoVND(totalPrice);
            }
        }
    }
}

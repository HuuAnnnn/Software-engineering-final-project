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
                    bool convt = decimal.TryParse(inputAmountInCurrencyForm,
                                                    NumberStyles.Currency,
                                                    CultureInfo.GetCultureInfo("vn-VN").NumberFormat,
                                                    out decval);
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
    }
}

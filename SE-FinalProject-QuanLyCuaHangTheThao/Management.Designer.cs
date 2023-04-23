
namespace SE_FinalProject_QuanLyCuaHangTheThao
{
    partial class Management
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbStatistic = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.inProductAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inProductPrice = new System.Windows.Forms.TextBox();
            this.displayProductImage = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.inProductName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbProductCategory = new System.Windows.Forms.ComboBox();
            this.btnInsertProduct = new System.Windows.Forms.Button();
            this.dgvDisplayNewProduct = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvReceipt = new System.Windows.Forms.DataGridView();
            this.pReceiptColunmReceiptID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pReceiptColunmDateCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pReceiptColunmEmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pReceiptColunmCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pReceiptColunmTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pReceiptColunmReceiptState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSearchReceipt = new System.Windows.Forms.Button();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.chooserSortType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.pageSetupDialog2 = new System.Windows.Forms.PageSetupDialog();
            this.dtpStart = new SE_FinalProject_QuanLyCuaHangTheThao.RashiDateTimePicker();
            this.dtpEnd = new SE_FinalProject_QuanLyCuaHangTheThao.RashiDateTimePicker();
            this.productId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productAmout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productImage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayProductImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayNewProduct)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceipt)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lbStatistic, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-1, 4);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(926, 526);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbStatistic
            // 
            this.lbStatistic.BackColor = System.Drawing.Color.OrangeRed;
            this.lbStatistic.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbStatistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbStatistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatistic.ForeColor = System.Drawing.Color.White;
            this.lbStatistic.Location = new System.Drawing.Point(3, 0);
            this.lbStatistic.Name = "lbStatistic";
            this.lbStatistic.Size = new System.Drawing.Size(920, 37);
            this.lbStatistic.TabIndex = 36;
            this.lbStatistic.Text = "Quản lý";
            this.lbStatistic.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(2, 39);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(921, 484);
            this.tabControl1.TabIndex = 37;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(913, 458);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nhân viên";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel4);
            this.tabPage2.Controls.Add(this.dgvDisplayNewProduct);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(913, 458);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Phiếu nhập/xuất hàng";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.06867F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.93133F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 166F));
            this.tableLayoutPanel4.Controls.Add(this.button1, 0, 6);
            this.tableLayoutPanel4.Controls.Add(this.inProductAmount, 2, 2);
            this.tableLayoutPanel4.Controls.Add(this.label4, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.inProductPrice, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.displayProductImage, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label6, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.inProductName, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.label7, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.cbProductCategory, 2, 3);
            this.tableLayoutPanel4.Controls.Add(this.btnInsertProduct, 0, 4);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 7;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.83871F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.16129F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(399, 454);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.tableLayoutPanel4.SetColumnSpan(this.button1, 3);
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Quicksand", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(3, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(393, 53);
            this.button1.TabIndex = 14;
            this.button1.Text = "Xuất phiếu nhập hàng";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inProductAmount
            // 
            this.inProductAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inProductAmount.Font = new System.Drawing.Font("Quicksand SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inProductAmount.Location = new System.Drawing.Point(236, 65);
            this.inProductAmount.Name = "inProductAmount";
            this.inProductAmount.Size = new System.Drawing.Size(160, 26);
            this.inProductAmount.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Quicksand", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(115, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số lượng";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // inProductPrice
            // 
            this.inProductPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inProductPrice.Font = new System.Drawing.Font("Quicksand SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inProductPrice.Location = new System.Drawing.Point(236, 37);
            this.inProductPrice.Name = "inProductPrice";
            this.inProductPrice.Size = new System.Drawing.Size(160, 26);
            this.inProductPrice.TabIndex = 7;
            // 
            // displayProductImage
            // 
            this.displayProductImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayProductImage.Location = new System.Drawing.Point(3, 3);
            this.displayProductImage.Name = "displayProductImage";
            this.tableLayoutPanel4.SetRowSpan(this.displayProductImage, 4);
            this.displayProductImage.Size = new System.Drawing.Size(106, 110);
            this.displayProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.displayProductImage.TabIndex = 4;
            this.displayProductImage.TabStop = false;
            this.displayProductImage.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Quicksand", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(115, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 34);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tên sản phẩm";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Quicksand", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(115, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 28);
            this.label6.TabIndex = 5;
            this.label6.Text = "Giá";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // inProductName
            // 
            this.inProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inProductName.Font = new System.Drawing.Font("Quicksand SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inProductName.Location = new System.Drawing.Point(236, 3);
            this.inProductName.Name = "inProductName";
            this.inProductName.Size = new System.Drawing.Size(160, 26);
            this.inProductName.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Quicksand", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(115, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 36);
            this.label7.TabIndex = 10;
            this.label7.Text = "Loại";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbProductCategory
            // 
            this.cbProductCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbProductCategory.Font = new System.Drawing.Font("Quicksand SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProductCategory.FormattingEnabled = true;
            this.cbProductCategory.Items.AddRange(new object[] {
            "Áo",
            "Quần",
            "Giày thể thao",
            "Balo",
            "Gậy GOLF",
            "Vợt Tennis",
            "Bóng bàn",
            "Câu cá",
            "Hộp thực phẩm",
            "Băng bảo vệ"});
            this.cbProductCategory.Location = new System.Drawing.Point(236, 96);
            this.cbProductCategory.Name = "cbProductCategory";
            this.cbProductCategory.Size = new System.Drawing.Size(160, 31);
            this.cbProductCategory.TabIndex = 11;
            // 
            // btnInsertProduct
            // 
            this.tableLayoutPanel4.SetColumnSpan(this.btnInsertProduct, 3);
            this.btnInsertProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInsertProduct.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.btnInsertProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertProduct.Font = new System.Drawing.Font("Quicksand", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertProduct.Location = new System.Drawing.Point(3, 132);
            this.btnInsertProduct.Name = "btnInsertProduct";
            this.btnInsertProduct.Size = new System.Drawing.Size(393, 60);
            this.btnInsertProduct.TabIndex = 12;
            this.btnInsertProduct.Text = "Thêm sản phẩm";
            this.btnInsertProduct.UseVisualStyleBackColor = true;
            this.btnInsertProduct.Click += new System.EventHandler(this.btnInsertProduct_Click);
            // 
            // dgvDisplayNewProduct
            // 
            this.dgvDisplayNewProduct.BackgroundColor = System.Drawing.Color.White;
            this.dgvDisplayNewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplayNewProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productId,
            this.productName,
            this.productPrice,
            this.productAmout,
            this.category,
            this.productImage});
            this.dgvDisplayNewProduct.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvDisplayNewProduct.GridColor = System.Drawing.Color.White;
            this.dgvDisplayNewProduct.Location = new System.Drawing.Point(407, 2);
            this.dgvDisplayNewProduct.Name = "dgvDisplayNewProduct";
            this.dgvDisplayNewProduct.Size = new System.Drawing.Size(504, 454);
            this.dgvDisplayNewProduct.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(913, 458);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Hóa đơn";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.dgvReceipt, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.10444F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.89556F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(913, 456);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // dgvReceipt
            // 
            this.dgvReceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceipt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pReceiptColunmReceiptID,
            this.pReceiptColunmDateCreated,
            this.pReceiptColunmEmployeeName,
            this.pReceiptColunmCustomerName,
            this.pReceiptColunmTotal,
            this.pReceiptColunmReceiptState});
            this.dgvReceipt.Location = new System.Drawing.Point(2, 93);
            this.dgvReceipt.Margin = new System.Windows.Forms.Padding(2);
            this.dgvReceipt.Name = "dgvReceipt";
            this.dgvReceipt.RowHeadersWidth = 51;
            this.dgvReceipt.RowTemplate.Height = 24;
            this.dgvReceipt.Size = new System.Drawing.Size(908, 360);
            this.dgvReceipt.TabIndex = 0;
            // 
            // pReceiptColunmReceiptID
            // 
            this.pReceiptColunmReceiptID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pReceiptColunmReceiptID.HeaderText = "Mã hóa đơn";
            this.pReceiptColunmReceiptID.MinimumWidth = 6;
            this.pReceiptColunmReceiptID.Name = "pReceiptColunmReceiptID";
            this.pReceiptColunmReceiptID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // pReceiptColunmDateCreated
            // 
            this.pReceiptColunmDateCreated.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pReceiptColunmDateCreated.HeaderText = "Ngày tạo";
            this.pReceiptColunmDateCreated.MinimumWidth = 6;
            this.pReceiptColunmDateCreated.Name = "pReceiptColunmDateCreated";
            // 
            // pReceiptColunmEmployeeName
            // 
            this.pReceiptColunmEmployeeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pReceiptColunmEmployeeName.HeaderText = "Tên nhân viên";
            this.pReceiptColunmEmployeeName.MinimumWidth = 6;
            this.pReceiptColunmEmployeeName.Name = "pReceiptColunmEmployeeName";
            // 
            // pReceiptColunmCustomerName
            // 
            this.pReceiptColunmCustomerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pReceiptColunmCustomerName.HeaderText = "Tên khách hàng";
            this.pReceiptColunmCustomerName.MinimumWidth = 6;
            this.pReceiptColunmCustomerName.Name = "pReceiptColunmCustomerName";
            // 
            // pReceiptColunmTotal
            // 
            this.pReceiptColunmTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pReceiptColunmTotal.HeaderText = "Tổng tiền";
            this.pReceiptColunmTotal.MinimumWidth = 6;
            this.pReceiptColunmTotal.Name = "pReceiptColunmTotal";
            // 
            // pReceiptColunmReceiptState
            // 
            this.pReceiptColunmReceiptState.HeaderText = "Trạng thái";
            this.pReceiptColunmReceiptState.MinimumWidth = 6;
            this.pReceiptColunmReceiptState.Name = "pReceiptColunmReceiptState";
            this.pReceiptColunmReceiptState.Width = 125;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 198F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.tableLayoutPanel3.Controls.Add(this.btnSearchReceipt, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel7, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.dtpStart, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.dtpEnd, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(908, 86);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // btnSearchReceipt
            // 
            this.btnSearchReceipt.BackColor = System.Drawing.Color.OrangeRed;
            this.btnSearchReceipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearchReceipt.FlatAppearance.BorderSize = 0;
            this.btnSearchReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchReceipt.ForeColor = System.Drawing.Color.White;
            this.btnSearchReceipt.Location = new System.Drawing.Point(747, 46);
            this.btnSearchReceipt.Name = "btnSearchReceipt";
            this.btnSearchReceipt.Size = new System.Drawing.Size(158, 37);
            this.btnSearchReceipt.TabIndex = 35;
            this.btnSearchReceipt.Text = "Tìm";
            this.btnSearchReceipt.UseVisualStyleBackColor = false;
            this.btnSearchReceipt.Click += new System.EventHandler(this.btnSearchReceipt_Click);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.chooserSortType, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(548, 45);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(194, 24);
            this.tableLayoutPanel7.TabIndex = 7;
            // 
            // chooserSortType
            // 
            this.chooserSortType.FormattingEnabled = true;
            this.chooserSortType.Items.AddRange(new object[] {
            "Theo tổng tiền giảm",
            "Theo tổng tiền tăng",
            "Theo ngày giảm",
            "Theo ngày tăng"});
            this.chooserSortType.Location = new System.Drawing.Point(99, 2);
            this.chooserSortType.Margin = new System.Windows.Forms.Padding(2);
            this.chooserSortType.Name = "chooserSortType";
            this.chooserSortType.Size = new System.Drawing.Size(93, 21);
            this.chooserSortType.TabIndex = 0;
            this.chooserSortType.SelectedIndexChanged += new System.EventHandler(this.chooserSortType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sắp xếp theo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Từ ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(275, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đến ngày";
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(913, 458);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Tính lương";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dtpStart
            // 
            this.dtpStart.BorderColor = System.Drawing.Color.Gray;
            this.dtpStart.BorderSize = 0;
            this.dtpStart.FillColor = System.Drawing.Color.LightGray;
            this.dtpStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(2, 45);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(2);
            this.dtpStart.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(151, 35);
            this.dtpStart.TabIndex = 0;
            this.dtpStart.TextColor = System.Drawing.Color.Black;
            // 
            // dtpEnd
            // 
            this.dtpEnd.BorderColor = System.Drawing.Color.Gray;
            this.dtpEnd.BorderSize = 0;
            this.dtpEnd.FillColor = System.Drawing.Color.LightGray;
            this.dtpEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(275, 45);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(2);
            this.dtpEnd.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(156, 35);
            this.dtpEnd.TabIndex = 1;
            this.dtpEnd.TextColor = System.Drawing.Color.Black;
            // 
            // productId
            // 
            this.productId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.productId.HeaderText = "Mã sản phẩm";
            this.productId.Name = "productId";
            this.productId.Width = 96;
            // 
            // productName
            // 
            this.productName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.productName.HeaderText = "Tên sản phẩm";
            this.productName.Name = "productName";
            // 
            // productPrice
            // 
            this.productPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.productPrice.HeaderText = "Giá";
            this.productPrice.Name = "productPrice";
            this.productPrice.Width = 48;
            // 
            // productAmout
            // 
            this.productAmout.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.productAmout.HeaderText = "Số lượng";
            this.productAmout.Name = "productAmout";
            this.productAmout.Width = 74;
            // 
            // category
            // 
            this.category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.category.HeaderText = "Loại";
            this.category.Name = "category";
            this.category.Width = 52;
            // 
            // productImage
            // 
            this.productImage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productImage.HeaderText = "Hình";
            this.productImage.Name = "productImage";
            // 
            // Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 530);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Management";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayProductImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayNewProduct)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceipt)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbStatistic;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dgvReceipt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.ComboBox chooserSortType;
        private System.Windows.Forms.Label label3;
        private RashiDateTimePicker dtpStart;
        private RashiDateTimePicker dtpEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearchReceipt;
        private System.Windows.Forms.DataGridViewTextBoxColumn pReceiptColunmReceiptID;
        private System.Windows.Forms.DataGridViewTextBoxColumn pReceiptColunmDateCreated;
        private System.Windows.Forms.DataGridViewTextBoxColumn pReceiptColunmEmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn pReceiptColunmCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn pReceiptColunmTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn pReceiptColunmReceiptState;
        private System.Windows.Forms.DataGridView dgvDisplayNewProduct;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox inProductAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inProductPrice;
        private System.Windows.Forms.PictureBox displayProductImage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox inProductName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbProductCategory;
        private System.Windows.Forms.Button btnInsertProduct;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productId;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn productAmout;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn productImage;
    }
}
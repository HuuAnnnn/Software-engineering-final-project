namespace SE_FinalProject_QuanLyCuaHangTheThao
{
    partial class CartForm
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
            this.displayCart = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.displayTotalPrice = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.displayCart)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // displayCart
            // 
            this.displayCart.BackgroundColor = System.Drawing.Color.White;
            this.displayCart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.displayCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.amount,
            this.price,
            this.totalPrice});
            this.tableLayoutPanel1.SetColumnSpan(this.displayCart, 3);
            this.displayCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displayCart.Location = new System.Drawing.Point(3, 3);
            this.displayCart.Name = "displayCart";
            this.displayCart.Size = new System.Drawing.Size(906, 471);
            this.displayCart.TabIndex = 0;
            this.displayCart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.displayCart_CellContentClick);
            this.displayCart.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.displayCart_CellValueChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 211F));
            this.tableLayoutPanel1.Controls.Add(this.displayCart, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.displayTotalPrice, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.84962F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.15038F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(912, 532);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Quicksand", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(593, 477);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tổng tiền:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // displayTotalPrice
            // 
            this.displayTotalPrice.AutoSize = true;
            this.displayTotalPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displayTotalPrice.Font = new System.Drawing.Font("Quicksand", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayTotalPrice.Location = new System.Drawing.Point(704, 477);
            this.displayTotalPrice.Name = "displayTotalPrice";
            this.displayTotalPrice.Size = new System.Drawing.Size(205, 55);
            this.displayTotalPrice.TabIndex = 2;
            this.displayTotalPrice.Text = "đ 0";
            this.displayTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.id.HeaderText = "Mã sản phẩm";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 96;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "Tên sản phẩm";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // amount
            // 
            this.amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.amount.HeaderText = "Số lượng";
            this.amount.Name = "amount";
            this.amount.Width = 74;
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.price.HeaderText = "Đơn giá";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 69;
            // 
            // totalPrice
            // 
            this.totalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.totalPrice.HeaderText = "Thành tiền";
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.ReadOnly = true;
            this.totalPrice.Width = 83;
            // 
            // CartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(912, 532);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CartForm";
            ((System.ComponentModel.ISupportInitialize)(this.displayCart)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView displayCart;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label displayTotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPrice;
    }
}
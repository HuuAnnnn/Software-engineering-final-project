
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
            this.dtpStart = new SE_FinalProject_QuanLyCuaHangTheThao.RashiDateTimePicker();
            this.dtpEnd = new SE_FinalProject_QuanLyCuaHangTheThao.RashiDateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.pageSetupDialog2 = new System.Windows.Forms.PageSetupDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-1, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1234, 647);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbStatistic
            // 
            this.lbStatistic.BackColor = System.Drawing.Color.OrangeRed;
            this.lbStatistic.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbStatistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbStatistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatistic.ForeColor = System.Drawing.Color.White;
            this.lbStatistic.Location = new System.Drawing.Point(4, 0);
            this.lbStatistic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStatistic.Name = "lbStatistic";
            this.lbStatistic.Size = new System.Drawing.Size(1226, 45);
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
            this.tabControl1.Location = new System.Drawing.Point(3, 48);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1228, 596);
            this.tabControl1.TabIndex = 37;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1220, 567);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nhân viên";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1220, 567);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Phiếu nhập/xuất hàng";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel2);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1220, 567);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.10444F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.89556F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1217, 561);
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
            this.dgvReceipt.Location = new System.Drawing.Point(3, 115);
            this.dgvReceipt.Name = "dgvReceipt";
            this.dgvReceipt.RowHeadersWidth = 51;
            this.dgvReceipt.RowTemplate.Height = 24;
            this.dgvReceipt.Size = new System.Drawing.Size(1211, 443);
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
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 264F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 217F));
            this.tableLayoutPanel3.Controls.Add(this.btnSearchReceipt, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel7, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.dtpStart, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.dtpEnd, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1211, 106);
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
            this.btnSearchReceipt.Location = new System.Drawing.Point(998, 57);
            this.btnSearchReceipt.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchReceipt.Name = "btnSearchReceipt";
            this.btnSearchReceipt.Size = new System.Drawing.Size(209, 45);
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
            this.tableLayoutPanel7.Location = new System.Drawing.Point(733, 56);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(258, 30);
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
            this.chooserSortType.Location = new System.Drawing.Point(132, 3);
            this.chooserSortType.Name = "chooserSortType";
            this.chooserSortType.Size = new System.Drawing.Size(123, 24);
            this.chooserSortType.TabIndex = 0;
            this.chooserSortType.SelectedIndexChanged += new System.EventHandler(this.chooserSortType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sắp xếp theo:";
            // 
            // dtpStart
            // 
            this.dtpStart.BorderColor = System.Drawing.Color.Gray;
            this.dtpStart.BorderSize = 0;
            this.dtpStart.FillColor = System.Drawing.Color.LightGray;
            this.dtpStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(3, 56);
            this.dtpStart.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 35);
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
            this.dtpEnd.Location = new System.Drawing.Point(368, 56);
            this.dtpEnd.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(206, 35);
            this.dtpEnd.TabIndex = 1;
            this.dtpEnd.TextColor = System.Drawing.Color.Black;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Từ ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(368, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đến ngày";
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1220, 567);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Tính lương";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 652);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Management";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
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
    }
}
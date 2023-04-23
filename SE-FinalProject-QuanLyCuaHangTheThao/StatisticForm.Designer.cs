namespace SE_FinalProject_QuanLyCuaHangTheThao
{
    partial class StatisticForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.charRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.charProduct = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbStatistic = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lbStartDate = new System.Windows.Forms.Label();
            this.lbEndDate = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnStatisticProduct = new System.Windows.Forms.Button();
            this.btnStatisticRevenue = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpStartDate = new SE_FinalProject_QuanLyCuaHangTheThao.RashiDateTimePicker();
            this.dtpEndDate = new SE_FinalProject_QuanLyCuaHangTheThao.RashiDateTimePicker();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.charRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charProduct)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(-4, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1234, 693);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.93317F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.06683F));
            this.tableLayoutPanel2.Controls.Add(this.charRevenue, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.charProduct, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 130);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1228, 559);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // charRevenue
            // 
            chartArea1.Name = "ChartArea1";
            this.charRevenue.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.charRevenue.Legends.Add(legend1);
            this.charRevenue.Location = new System.Drawing.Point(493, 3);
            this.charRevenue.Name = "charRevenue";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Revenue";
            this.charRevenue.Series.Add(series1);
            this.charRevenue.Size = new System.Drawing.Size(732, 553);
            this.charRevenue.TabIndex = 0;
            this.charRevenue.Text = "chart1";
            // 
            // charProduct
            // 
            chartArea2.Name = "ChartArea1";
            this.charProduct.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.charProduct.Legends.Add(legend2);
            this.charProduct.Location = new System.Drawing.Point(3, 3);
            this.charProduct.Name = "charProduct";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.charProduct.Series.Add(series2);
            this.charProduct.Size = new System.Drawing.Size(484, 553);
            this.charProduct.TabIndex = 1;
            this.charProduct.Text = "chart2";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.lbStatistic, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1219, 125);
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
            this.lbStatistic.Size = new System.Drawing.Size(1211, 31);
            this.lbStatistic.TabIndex = 35;
            this.lbStatistic.Text = "THỐNG KÊ";
            this.lbStatistic.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.66795F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.33205F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 163F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel6, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 35);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1212, 87);
            this.tableLayoutPanel3.TabIndex = 36;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.btnExportExcel, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(1051, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(157, 81);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.BackColor = System.Drawing.Color.Green;
            this.btnExportExcel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExportExcel.FlatAppearance.BorderSize = 0;
            this.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcel.ForeColor = System.Drawing.Color.White;
            this.btnExportExcel.Location = new System.Drawing.Point(4, 4);
            this.btnExportExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(149, 73);
            this.btnExportExcel.TabIndex = 33;
            this.btnExportExcel.Text = "Xuất file Excel";
            this.btnExportExcel.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.36364F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.63636F));
            this.tableLayoutPanel4.Controls.Add(this.dtpStartDate, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.dtpEndDate, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.lbStartDate, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lbEndDate, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.03704F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.96296F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(556, 81);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // lbStartDate
            // 
            this.lbStartDate.AutoSize = true;
            this.lbStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStartDate.Location = new System.Drawing.Point(3, 0);
            this.lbStartDate.Name = "lbStartDate";
            this.lbStartDate.Size = new System.Drawing.Size(68, 20);
            this.lbStartDate.TabIndex = 2;
            this.lbStartDate.Text = "Từ ngày";
            // 
            // lbEndDate
            // 
            this.lbEndDate.AutoSize = true;
            this.lbEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEndDate.Location = new System.Drawing.Point(271, 0);
            this.lbEndDate.Name = "lbEndDate";
            this.lbEndDate.Size = new System.Drawing.Size(79, 20);
            this.lbEndDate.TabIndex = 3;
            this.lbEndDate.Text = "Đến ngày";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.btnStatisticProduct, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.btnStatisticRevenue, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(565, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.5679F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.4321F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(472, 81);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // btnStatisticProduct
            // 
            this.btnStatisticProduct.BackColor = System.Drawing.Color.OrangeRed;
            this.btnStatisticProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStatisticProduct.FlatAppearance.BorderSize = 0;
            this.btnStatisticProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatisticProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatisticProduct.ForeColor = System.Drawing.Color.White;
            this.btnStatisticProduct.Location = new System.Drawing.Point(240, 32);
            this.btnStatisticProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnStatisticProduct.Name = "btnStatisticProduct";
            this.btnStatisticProduct.Size = new System.Drawing.Size(228, 45);
            this.btnStatisticProduct.TabIndex = 35;
            this.btnStatisticProduct.Text = "Sản phẩm";
            this.btnStatisticProduct.UseVisualStyleBackColor = false;
            // 
            // btnStatisticRevenue
            // 
            this.btnStatisticRevenue.BackColor = System.Drawing.Color.OrangeRed;
            this.btnStatisticRevenue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStatisticRevenue.FlatAppearance.BorderSize = 0;
            this.btnStatisticRevenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatisticRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatisticRevenue.ForeColor = System.Drawing.Color.White;
            this.btnStatisticRevenue.Location = new System.Drawing.Point(4, 32);
            this.btnStatisticRevenue.Margin = new System.Windows.Forms.Padding(4);
            this.btnStatisticRevenue.Name = "btnStatisticRevenue";
            this.btnStatisticRevenue.Size = new System.Drawing.Size(228, 45);
            this.btnStatisticRevenue.TabIndex = 34;
            this.btnStatisticRevenue.Text = "Doanh thu";
            this.btnStatisticRevenue.UseVisualStyleBackColor = false;
            this.btnStatisticRevenue.Click += new System.EventHandler(this.btnStatisticRevenue_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Theo";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.BorderColor = System.Drawing.Color.Gray;
            this.dtpStartDate.BorderSize = 0;
            this.dtpStartDate.FillColor = System.Drawing.Color.DarkGray;
            this.dtpStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(3, 33);
            this.dtpStartDate.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(226, 35);
            this.dtpStartDate.TabIndex = 0;
            this.dtpStartDate.TextColor = System.Drawing.Color.Black;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.BorderColor = System.Drawing.Color.Gray;
            this.dtpEndDate.BorderSize = 0;
            this.dtpEndDate.FillColor = System.Drawing.Color.DarkGray;
            this.dtpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(271, 33);
            this.dtpEndDate.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(238, 35);
            this.dtpEndDate.TabIndex = 1;
            this.dtpEndDate.TextColor = System.Drawing.Color.Black;
            // 
            // StatisticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 692);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StatisticForm";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.charRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charProduct)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart charRevenue;
        private System.Windows.Forms.DataVisualization.Charting.Chart charProduct;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbStatistic;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private RashiDateTimePicker dtpStartDate;
        private RashiDateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lbStartDate;
        private System.Windows.Forms.Label lbEndDate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Button btnStatisticProduct;
        private System.Windows.Forms.Button btnStatisticRevenue;
    }
}
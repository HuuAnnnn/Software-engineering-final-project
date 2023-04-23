namespace SE_FinalProject_QuanLyCuaHangTheThao
{
    partial class Homepage
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
            this.components = new System.ComponentModel.Container();
            this.panel3 = new System.Windows.Forms.Panel();
            this.displayDatetime = new System.Windows.Forms.Label();
            this.displayClock = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.displayDatetime);
            this.panel3.Controls.Add(this.displayClock);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(934, 530);
            this.panel3.TabIndex = 11;
            // 
            // displayDatetime
            // 
            this.displayDatetime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.displayDatetime.BackColor = System.Drawing.Color.Transparent;
            this.displayDatetime.Font = new System.Drawing.Font("Quicksand", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayDatetime.ForeColor = System.Drawing.Color.OrangeRed;
            this.displayDatetime.Location = new System.Drawing.Point(269, 266);
            this.displayDatetime.Name = "displayDatetime";
            this.displayDatetime.Size = new System.Drawing.Size(403, 40);
            this.displayDatetime.TabIndex = 1;
            this.displayDatetime.Text = "Wednessday, 20th April 2023";
            this.displayDatetime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displayClock
            // 
            this.displayClock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.displayClock.AutoSize = true;
            this.displayClock.BackColor = System.Drawing.Color.Transparent;
            this.displayClock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.displayClock.Font = new System.Drawing.Font("Quicksand", 99.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayClock.ForeColor = System.Drawing.Color.OrangeRed;
            this.displayClock.Location = new System.Drawing.Point(170, 85);
            this.displayClock.Name = "displayClock";
            this.displayClock.Size = new System.Drawing.Size(619, 197);
            this.displayClock.TabIndex = 0;
            this.displayClock.Text = "09:30:30";
            this.displayClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(203, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(559, 52);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cửa hàng bán dụng cụ thể thao";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Quicksand", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(396, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 52);
            this.label2.TabIndex = 3;
            this.label2.Text = "Xin chào!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 530);
            this.Controls.Add(this.panel3);
            this.Name = "Homepage";
            this.Text = "Homepage";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label displayDatetime;
        private System.Windows.Forms.Label displayClock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}
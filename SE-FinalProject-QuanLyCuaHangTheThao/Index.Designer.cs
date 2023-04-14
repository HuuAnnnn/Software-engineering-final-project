namespace SE_FinalProject_QuanLyCuaHangTheThao
{
    partial class Index
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.displayEmpUsername = new System.Windows.Forms.Label();
            this.displayEmplTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imgUsername = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUsername)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Quicksand SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(61, 81);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(53, 31);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Quicksand SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Chức vụ:";
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblWelcome.Font = new System.Drawing.Font("Quicksand", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(17, 16);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(146, 43);
            this.lblWelcome.TabIndex = 6;
            this.lblWelcome.Text = "Xin chào!";
            // 
            // displayEmpUsername
            // 
            this.displayEmpUsername.AutoSize = true;
            this.displayEmpUsername.Font = new System.Drawing.Font("Quicksand", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayEmpUsername.Location = new System.Drawing.Point(120, 80);
            this.displayEmpUsername.Name = "displayEmpUsername";
            this.displayEmpUsername.Size = new System.Drawing.Size(168, 31);
            this.displayEmpUsername.TabIndex = 7;
            this.displayEmpUsername.Text = "Nguyễn Hữu An";
            // 
            // displayEmplTitle
            // 
            this.displayEmplTitle.Font = new System.Drawing.Font("Quicksand", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayEmplTitle.Location = new System.Drawing.Point(164, 136);
            this.displayEmplTitle.Name = "displayEmplTitle";
            this.displayEmplTitle.Size = new System.Drawing.Size(168, 31);
            this.displayEmplTitle.TabIndex = 8;
            this.displayEmplTitle.Text = "Thu ngân";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.displayEmplTitle);
            this.panel1.Controls.Add(this.displayEmpUsername);
            this.panel1.Controls.Add(this.lblWelcome);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.imgUsername);
            this.panel1.Location = new System.Drawing.Point(24, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 199);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::SE_FinalProject_QuanLyCuaHangTheThao.Properties.Resources.tag_index_1;
            this.pictureBox1.Location = new System.Drawing.Point(25, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // imgUsername
            // 
            this.imgUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgUsername.Image = global::SE_FinalProject_QuanLyCuaHangTheThao.Properties.Resources.username_index_1;
            this.imgUsername.Location = new System.Drawing.Point(25, 80);
            this.imgUsername.Name = "imgUsername";
            this.imgUsername.Size = new System.Drawing.Size(32, 32);
            this.imgUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgUsername.TabIndex = 2;
            this.imgUsername.TabStop = false;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(911, 533);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Index";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUsername)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label displayEmpUsername;
        private System.Windows.Forms.Label displayEmplTitle;
        private System.Windows.Forms.Panel panel1;
    }
}
namespace SE_FinalProject_QuanLyCuaHangTheThao
{
    partial class ChangePassword
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
            System.Windows.Forms.PictureBox pictureBox1;
            this.inPassword = new System.Windows.Forms.TextBox();
            this.inUsername = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximumsize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.inConfirmPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            pictureBox1.Image = global::SE_FinalProject_QuanLyCuaHangTheThao.Properties.Resources.change_password;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new System.Drawing.Point(12, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(462, 469);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // inPassword
            // 
            this.inPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inPassword.BackColor = System.Drawing.Color.Gainsboro;
            this.inPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inPassword.Font = new System.Drawing.Font("Quicksand", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inPassword.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.inPassword.Location = new System.Drawing.Point(501, 290);
            this.inPassword.Multiline = true;
            this.inPassword.Name = "inPassword";
            this.inPassword.Size = new System.Drawing.Size(583, 38);
            this.inPassword.TabIndex = 20;
            this.inPassword.Text = "Mật khẩu";
            this.inPassword.WordWrap = false;
            this.inPassword.Enter += new System.EventHandler(this.inPassword_Enter);
            this.inPassword.Leave += new System.EventHandler(this.inPassword_Leave);
            // 
            // inUsername
            // 
            this.inUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inUsername.BackColor = System.Drawing.Color.Gainsboro;
            this.inUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inUsername.Font = new System.Drawing.Font("Quicksand", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inUsername.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.inUsername.Location = new System.Drawing.Point(501, 186);
            this.inUsername.Multiline = true;
            this.inUsername.Name = "inUsername";
            this.inUsername.Size = new System.Drawing.Size(583, 38);
            this.inUsername.TabIndex = 21;
            this.inUsername.Text = "Tên người dùng";
            this.inUsername.Enter += new System.EventHandler(this.inUsername_Enter);
            this.inUsername.Leave += new System.EventHandler(this.inUsername_Leave);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Quicksand", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnCancel.Location = new System.Drawing.Point(754, 458);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(151, 54);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Thoát";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChangePassword.BackColor = System.Drawing.Color.OrangeRed;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Quicksand", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnChangePassword.Location = new System.Drawing.Point(933, 458);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(151, 54);
            this.btnChangePassword.TabIndex = 25;
            this.btnChangePassword.Text = "Đổi mật khẩu";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Quicksand SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(495, 249);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(150, 31);
            this.lblPassword.TabIndex = 24;
            this.lblPassword.Text = "Mật khẩu mới";
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Quicksand SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(495, 145);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(186, 31);
            this.lblUsername.TabIndex = 23;
            this.lblUsername.Text = "Mật khẩu hiện tại";
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Quicksand", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(485, 43);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(621, 95);
            this.lblWelcome.TabIndex = 22;
            this.lblWelcome.Text = "Thay đổi mật khẩu";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.White;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnMinimize.Location = new System.Drawing.Point(977, 5);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(39, 26);
            this.btnMinimize.TabIndex = 17;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Text = "🗕";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximumsize
            // 
            this.btnMaximumsize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximumsize.BackColor = System.Drawing.Color.White;
            this.btnMaximumsize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMaximumsize.FlatAppearance.BorderSize = 0;
            this.btnMaximumsize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximumsize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximumsize.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnMaximumsize.Location = new System.Drawing.Point(1022, 5);
            this.btnMaximumsize.Name = "btnMaximumsize";
            this.btnMaximumsize.Size = new System.Drawing.Size(39, 26);
            this.btnMaximumsize.TabIndex = 18;
            this.btnMaximumsize.Text = "🗖";
            this.btnMaximumsize.UseVisualStyleBackColor = false;
            this.btnMaximumsize.Click += new System.EventHandler(this.btnMaximumsize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnClose.Location = new System.Drawing.Point(1067, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 26);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "⨉";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // inConfirmPassword
            // 
            this.inConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inConfirmPassword.BackColor = System.Drawing.Color.Gainsboro;
            this.inConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inConfirmPassword.Font = new System.Drawing.Font("Quicksand", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inConfirmPassword.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.inConfirmPassword.Location = new System.Drawing.Point(501, 394);
            this.inConfirmPassword.Multiline = true;
            this.inConfirmPassword.Name = "inConfirmPassword";
            this.inConfirmPassword.Size = new System.Drawing.Size(583, 38);
            this.inConfirmPassword.TabIndex = 27;
            this.inConfirmPassword.Text = "Nhập lại mật khẩu";
            this.inConfirmPassword.WordWrap = false;
            this.inConfirmPassword.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.inConfirmPassword.Enter += new System.EventHandler(this.inConfirmPassword_Enter);
            this.inConfirmPassword.Leave += new System.EventHandler(this.inConfirmPassword_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(495, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 31);
            this.label1.TabIndex = 28;
            this.label1.Text = "Nhập lại mật khẩu mới";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1109, 554);
            this.ControlBox = false;
            this.Controls.Add(this.inConfirmPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inPassword);
            this.Controls.Add(this.inUsername);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnMaximumsize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePassword";
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChangePassword_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inPassword;
        private System.Windows.Forms.TextBox inUsername;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximumsize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox inConfirmPassword;
        private System.Windows.Forms.Label label1;
    }
}
namespace SE_FinalProject_QuanLyCuaHangTheThao
{
    partial class Login
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
            this.container = new System.Windows.Forms.Panel();
            this.inPassword = new System.Windows.Forms.TextBox();
            this.inUsername = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximumsize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.container.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            pictureBox1.Image = global::SE_FinalProject_QuanLyCuaHangTheThao.Properties.Resources.LoginImage2;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new System.Drawing.Point(22, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(512, 512);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // container
            // 
            this.container.AutoSize = true;
            this.container.BackColor = System.Drawing.Color.White;
            this.container.Controls.Add(this.inPassword);
            this.container.Controls.Add(this.inUsername);
            this.container.Controls.Add(this.btnCancel);
            this.container.Controls.Add(this.btnLogin);
            this.container.Controls.Add(this.lblPassword);
            this.container.Controls.Add(this.lblUsername);
            this.container.Controls.Add(this.lblWelcome);
            this.container.Controls.Add(pictureBox1);
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(0, 0);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(1125, 593);
            this.container.TabIndex = 0;
            // 
            // inPassword
            // 
            this.inPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inPassword.BackColor = System.Drawing.Color.Gainsboro;
            this.inPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inPassword.Font = new System.Drawing.Font("Quicksand", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inPassword.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.inPassword.Location = new System.Drawing.Point(597, 344);
            this.inPassword.Multiline = true;
            this.inPassword.Name = "inPassword";
            this.inPassword.Size = new System.Drawing.Size(475, 38);
            this.inPassword.TabIndex = 4;
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
            this.inUsername.Location = new System.Drawing.Point(597, 240);
            this.inUsername.Multiline = true;
            this.inUsername.Name = "inUsername";
            this.inUsername.Size = new System.Drawing.Size(475, 38);
            this.inUsername.TabIndex = 4;
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
            this.btnCancel.Location = new System.Drawing.Point(742, 428);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(151, 54);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Thoát";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.BackColor = System.Drawing.Color.OrangeRed;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Quicksand", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogin.Location = new System.Drawing.Point(921, 428);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(151, 54);
            this.btnLogin.TabIndex = 15;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Quicksand SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(591, 303);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(107, 31);
            this.lblPassword.TabIndex = 14;
            this.lblPassword.Text = "Mật khẩu";
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Quicksand SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(591, 199);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(161, 31);
            this.lblUsername.TabIndex = 13;
            this.lblUsername.Text = "Tên đăng nhập";
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Quicksand", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(671, 45);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(350, 95);
            this.lblWelcome.TabIndex = 11;
            this.lblWelcome.Text = "WELCOME";
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
            this.btnMinimize.Location = new System.Drawing.Point(994, 1);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(39, 26);
            this.btnMinimize.TabIndex = 1;
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
            this.btnMaximumsize.Location = new System.Drawing.Point(1039, 1);
            this.btnMaximumsize.Name = "btnMaximumsize";
            this.btnMaximumsize.Size = new System.Drawing.Size(39, 26);
            this.btnMaximumsize.TabIndex = 2;
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
            this.btnClose.Location = new System.Drawing.Point(1084, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 26);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "⨉";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1125, 593);
            this.ControlBox = false;
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnMaximumsize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.container.ResumeLayout(false);
            this.container.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.TextBox inUsername;
        private System.Windows.Forms.TextBox inPassword;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximumsize;
        private System.Windows.Forms.Button btnClose;
    }
}
namespace MarketYönetimSistemi
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginAdminEmailTxt = new System.Windows.Forms.TextBox();
            this.LoginAdminPasswordTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.AdminGb = new System.Windows.Forms.GroupBox();
            this.AdminLoginBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UserLoginBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.LoginUserPasswordTxt = new System.Windows.Forms.TextBox();
            this.LoginUserEmailTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.UserSignUpBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AdminGb.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(270, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email";
            // 
            // LoginAdminEmailTxt
            // 
            this.LoginAdminEmailTxt.Location = new System.Drawing.Point(28, 64);
            this.LoginAdminEmailTxt.Name = "LoginAdminEmailTxt";
            this.LoginAdminEmailTxt.Size = new System.Drawing.Size(100, 22);
            this.LoginAdminEmailTxt.TabIndex = 3;
            // 
            // LoginAdminPasswordTxt
            // 
            this.LoginAdminPasswordTxt.Location = new System.Drawing.Point(28, 130);
            this.LoginAdminPasswordTxt.Name = "LoginAdminPasswordTxt";
            this.LoginAdminPasswordTxt.PasswordChar = '*';
            this.LoginAdminPasswordTxt.Size = new System.Drawing.Size(100, 22);
            this.LoginAdminPasswordTxt.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // AdminGb
            // 
            this.AdminGb.Controls.Add(this.AdminLoginBtn);
            this.AdminGb.Controls.Add(this.label3);
            this.AdminGb.Controls.Add(this.LoginAdminPasswordTxt);
            this.AdminGb.Controls.Add(this.LoginAdminEmailTxt);
            this.AdminGb.Controls.Add(this.label2);
            this.AdminGb.Location = new System.Drawing.Point(114, 188);
            this.AdminGb.Name = "AdminGb";
            this.AdminGb.Size = new System.Drawing.Size(182, 233);
            this.AdminGb.TabIndex = 6;
            this.AdminGb.TabStop = false;
            this.AdminGb.Text = "Admin Login";
            // 
            // AdminLoginBtn
            // 
            this.AdminLoginBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AdminLoginBtn.BackColor = System.Drawing.Color.Lime;
            this.AdminLoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AdminLoginBtn.Location = new System.Drawing.Point(28, 176);
            this.AdminLoginBtn.Name = "AdminLoginBtn";
            this.AdminLoginBtn.Size = new System.Drawing.Size(100, 38);
            this.AdminLoginBtn.TabIndex = 6;
            this.AdminLoginBtn.Text = "Login";
            this.AdminLoginBtn.UseVisualStyleBackColor = false;
            this.AdminLoginBtn.Click += new System.EventHandler(this.AdminLoginBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UserLoginBtn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.LoginUserPasswordTxt);
            this.groupBox1.Controls.Add(this.LoginUserEmailTxt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(302, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 233);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Login";
            // 
            // UserLoginBtn
            // 
            this.UserLoginBtn.BackColor = System.Drawing.Color.Lime;
            this.UserLoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UserLoginBtn.Location = new System.Drawing.Point(28, 176);
            this.UserLoginBtn.Name = "UserLoginBtn";
            this.UserLoginBtn.Size = new System.Drawing.Size(100, 38);
            this.UserLoginBtn.TabIndex = 7;
            this.UserLoginBtn.Text = "Login";
            this.UserLoginBtn.UseVisualStyleBackColor = false;
            this.UserLoginBtn.Click += new System.EventHandler(this.UserLoginBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password";
            // 
            // LoginUserPasswordTxt
            // 
            this.LoginUserPasswordTxt.Location = new System.Drawing.Point(28, 130);
            this.LoginUserPasswordTxt.Name = "LoginUserPasswordTxt";
            this.LoginUserPasswordTxt.PasswordChar = '*';
            this.LoginUserPasswordTxt.Size = new System.Drawing.Size(100, 22);
            this.LoginUserPasswordTxt.TabIndex = 4;
            // 
            // LoginUserEmailTxt
            // 
            this.LoginUserEmailTxt.Location = new System.Drawing.Point(28, 64);
            this.LoginUserEmailTxt.Name = "LoginUserEmailTxt";
            this.LoginUserEmailTxt.Size = new System.Drawing.Size(100, 22);
            this.LoginUserEmailTxt.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Email";
            // 
            // UserSignUpBtn
            // 
            this.UserSignUpBtn.BackColor = System.Drawing.Color.Red;
            this.UserSignUpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UserSignUpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UserSignUpBtn.ForeColor = System.Drawing.Color.White;
            this.UserSignUpBtn.Location = new System.Drawing.Point(497, 12);
            this.UserSignUpBtn.Name = "UserSignUpBtn";
            this.UserSignUpBtn.Size = new System.Drawing.Size(107, 33);
            this.UserSignUpBtn.TabIndex = 8;
            this.UserSignUpBtn.Text = "Sign Up";
            this.UserSignUpBtn.UseVisualStyleBackColor = false;
            this.UserSignUpBtn.Click += new System.EventHandler(this.UserSignUpBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MarketYönetimSistemi.Properties.Resources.Login;
            this.pictureBox1.Location = new System.Drawing.Point(256, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 450);
            this.Controls.Add(this.UserSignUpBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AdminGb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.AdminGb.ResumeLayout(false);
            this.AdminGb.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LoginAdminEmailTxt;
        private System.Windows.Forms.TextBox LoginAdminPasswordTxt;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox AdminGb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LoginUserPasswordTxt;
        private System.Windows.Forms.TextBox LoginUserEmailTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AdminLoginBtn;
        private System.Windows.Forms.Button UserLoginBtn;
        private System.Windows.Forms.Button UserSignUpBtn;
    }
}


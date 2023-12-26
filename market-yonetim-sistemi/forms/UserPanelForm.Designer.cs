namespace MarketYönetimSistemi
{
    partial class UserPanelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPanelForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.UserOrderBtn = new System.Windows.Forms.Button();
            this.UserCartBtn = new System.Windows.Forms.Button();
            this.UserListTitleLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.UserOrderBtn);
            this.panel1.Controls.Add(this.UserCartBtn);
            this.panel1.Controls.Add(this.UserListTitleLbl);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(938, 98);
            this.panel1.TabIndex = 0;
            // 
            // UserOrderBtn
            // 
            this.UserOrderBtn.BackColor = System.Drawing.Color.LightCoral;
            this.UserOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UserOrderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UserOrderBtn.Location = new System.Drawing.Point(806, 30);
            this.UserOrderBtn.Name = "UserOrderBtn";
            this.UserOrderBtn.Size = new System.Drawing.Size(94, 36);
            this.UserOrderBtn.TabIndex = 3;
            this.UserOrderBtn.Text = "My Order";
            this.UserOrderBtn.UseVisualStyleBackColor = false;
            this.UserOrderBtn.Click += new System.EventHandler(this.UserOrderBtn_Click);
            // 
            // UserCartBtn
            // 
            this.UserCartBtn.BackColor = System.Drawing.Color.LightCoral;
            this.UserCartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UserCartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UserCartBtn.Location = new System.Drawing.Point(687, 30);
            this.UserCartBtn.Name = "UserCartBtn";
            this.UserCartBtn.Size = new System.Drawing.Size(94, 36);
            this.UserCartBtn.TabIndex = 2;
            this.UserCartBtn.Text = "My Cart";
            this.UserCartBtn.UseVisualStyleBackColor = false;
            this.UserCartBtn.Click += new System.EventHandler(this.UserCartBtn_Click);
            // 
            // UserListTitleLbl
            // 
            this.UserListTitleLbl.AutoSize = true;
            this.UserListTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UserListTitleLbl.ForeColor = System.Drawing.Color.White;
            this.UserListTitleLbl.Location = new System.Drawing.Point(153, 25);
            this.UserListTitleLbl.Name = "UserListTitleLbl";
            this.UserListTitleLbl.Size = new System.Drawing.Size(152, 36);
            this.UserListTitleLbl.TabIndex = 1;
            this.UserListTitleLbl.Text = "Shopping";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(47, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(-1, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(935, 435);
            this.panel2.TabIndex = 1;
            // 
            // UserPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 525);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UserPanelForm";
            this.Text = "UserPanelForm";
            this.Load += new System.EventHandler(this.UserPanelForm_Load);
            this.SizeChanged += new System.EventHandler(this.UserPanelForm_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label UserListTitleLbl;
        private System.Windows.Forms.Button UserCartBtn;
        private System.Windows.Forms.Button UserOrderBtn;
    }
}
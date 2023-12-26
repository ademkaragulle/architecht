namespace MarketYönetimSistemi
{
    partial class UserPanel
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
            this.UserPnl = new System.Windows.Forms.Panel();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.BasketBtn = new System.Windows.Forms.Button();
            this.WelcomeLbl = new System.Windows.Forms.Label();
            this.ProductPnl = new System.Windows.Forms.Panel();
            this.UserPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserPnl
            // 
            this.UserPnl.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.UserPnl.Controls.Add(this.ExitBtn);
            this.UserPnl.Controls.Add(this.BasketBtn);
            this.UserPnl.Controls.Add(this.WelcomeLbl);
            this.UserPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserPnl.Location = new System.Drawing.Point(0, 0);
            this.UserPnl.Name = "UserPnl";
            this.UserPnl.Size = new System.Drawing.Size(1568, 100);
            this.UserPnl.TabIndex = 0;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(1460, 37);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBtn.TabIndex = 2;
            this.ExitBtn.Text = "Çıkış Yap";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // BasketBtn
            // 
            this.BasketBtn.Location = new System.Drawing.Point(1355, 37);
            this.BasketBtn.Name = "BasketBtn";
            this.BasketBtn.Size = new System.Drawing.Size(75, 23);
            this.BasketBtn.TabIndex = 1;
            this.BasketBtn.Text = "Sepet";
            this.BasketBtn.UseVisualStyleBackColor = true;
            this.BasketBtn.Click += new System.EventHandler(this.BasketBtn_Click);
            // 
            // WelcomeLbl
            // 
            this.WelcomeLbl.AutoSize = true;
            this.WelcomeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLbl.Location = new System.Drawing.Point(21, 30);
            this.WelcomeLbl.Name = "WelcomeLbl";
            this.WelcomeLbl.Size = new System.Drawing.Size(132, 29);
            this.WelcomeLbl.TabIndex = 0;
            this.WelcomeLbl.Text = "Hoşgeldin";
            // 
            // ProductPnl
            // 
            this.ProductPnl.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ProductPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductPnl.Location = new System.Drawing.Point(0, 100);
            this.ProductPnl.Name = "ProductPnl";
            this.ProductPnl.Size = new System.Drawing.Size(1568, 726);
            this.ProductPnl.TabIndex = 1;
            // 
            // UserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1568, 826);
            this.Controls.Add(this.ProductPnl);
            this.Controls.Add(this.UserPnl);
            this.Name = "UserPanel";
            this.Text = "Kullanıcı Paneli";
            this.Load += new System.EventHandler(this.UserPanel_Load);
            this.UserPnl.ResumeLayout(false);
            this.UserPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel UserPnl;
        private System.Windows.Forms.Panel ProductPnl;
        private System.Windows.Forms.Label WelcomeLbl;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button BasketBtn;
    }
}
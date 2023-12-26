namespace MarketYönetimSistemi.forms
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
            this.CartDgv = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.BuyToCartBtn = new System.Windows.Forms.Button();
            this.DeleteCartBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CartDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // CartDgv
            // 
            this.CartDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CartDgv.Location = new System.Drawing.Point(28, 44);
            this.CartDgv.Name = "CartDgv";
            this.CartDgv.RowHeadersWidth = 51;
            this.CartDgv.RowTemplate.Height = 24;
            this.CartDgv.Size = new System.Drawing.Size(597, 214);
            this.CartDgv.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(34, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "My Cart";
            // 
            // BuyToCartBtn
            // 
            this.BuyToCartBtn.BackColor = System.Drawing.Color.Lime;
            this.BuyToCartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BuyToCartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BuyToCartBtn.Location = new System.Drawing.Point(517, 264);
            this.BuyToCartBtn.Name = "BuyToCartBtn";
            this.BuyToCartBtn.Size = new System.Drawing.Size(108, 36);
            this.BuyToCartBtn.TabIndex = 2;
            this.BuyToCartBtn.Text = "Buy";
            this.BuyToCartBtn.UseVisualStyleBackColor = false;
            this.BuyToCartBtn.Click += new System.EventHandler(this.BuyToCartBtn_Click);
            // 
            // DeleteCartBtn
            // 
            this.DeleteCartBtn.BackColor = System.Drawing.Color.Red;
            this.DeleteCartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteCartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DeleteCartBtn.Location = new System.Drawing.Point(393, 264);
            this.DeleteCartBtn.Name = "DeleteCartBtn";
            this.DeleteCartBtn.Size = new System.Drawing.Size(108, 36);
            this.DeleteCartBtn.TabIndex = 3;
            this.DeleteCartBtn.Text = "Delete";
            this.DeleteCartBtn.UseVisualStyleBackColor = false;
            this.DeleteCartBtn.Click += new System.EventHandler(this.DeleteCartBtn_Click);
            // 
            // CartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 312);
            this.Controls.Add(this.DeleteCartBtn);
            this.Controls.Add(this.BuyToCartBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CartDgv);
            this.Name = "CartForm";
            this.Text = "CartForm";
            this.Load += new System.EventHandler(this.CartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CartDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CartDgv;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BuyToCartBtn;
        private System.Windows.Forms.Button DeleteCartBtn;
    }
}
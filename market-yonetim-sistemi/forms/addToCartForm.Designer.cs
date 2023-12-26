namespace MarketYönetimSistemi.Controller
{
    partial class addToCartForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductQuantityNud = new System.Windows.Forms.NumericUpDown();
            this.ProductCategoryLbl = new System.Windows.Forms.Label();
            this.ProductStockLbl = new System.Windows.Forms.Label();
            this.ProductPriceLbl = new System.Windows.Forms.Label();
            this.ProductNameLbl = new System.Windows.Forms.Label();
            this.AddCartProductBtn = new System.Windows.Forms.Button();
            this.cartProductImg = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductQuantityNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartProductImg)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ProductQuantityNud);
            this.groupBox1.Controls.Add(this.ProductCategoryLbl);
            this.groupBox1.Controls.Add(this.ProductStockLbl);
            this.groupBox1.Controls.Add(this.ProductPriceLbl);
            this.groupBox1.Controls.Add(this.ProductNameLbl);
            this.groupBox1.Controls.Add(this.AddCartProductBtn);
            this.groupBox1.Controls.Add(this.cartProductImg);
            this.groupBox1.Location = new System.Drawing.Point(51, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 319);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "add User";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(157, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Miktar";
            // 
            // ProductQuantityNud
            // 
            this.ProductQuantityNud.Location = new System.Drawing.Point(161, 255);
            this.ProductQuantityNud.Name = "ProductQuantityNud";
            this.ProductQuantityNud.Size = new System.Drawing.Size(97, 22);
            this.ProductQuantityNud.TabIndex = 27;
            // 
            // ProductCategoryLbl
            // 
            this.ProductCategoryLbl.AutoSize = true;
            this.ProductCategoryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ProductCategoryLbl.Location = new System.Drawing.Point(275, 174);
            this.ProductCategoryLbl.Name = "ProductCategoryLbl";
            this.ProductCategoryLbl.Size = new System.Drawing.Size(149, 20);
            this.ProductCategoryLbl.TabIndex = 26;
            this.ProductCategoryLbl.Text = "Product Category: ";
            // 
            // ProductStockLbl
            // 
            this.ProductStockLbl.AutoSize = true;
            this.ProductStockLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ProductStockLbl.Location = new System.Drawing.Point(275, 133);
            this.ProductStockLbl.Name = "ProductStockLbl";
            this.ProductStockLbl.Size = new System.Drawing.Size(124, 20);
            this.ProductStockLbl.TabIndex = 24;
            this.ProductStockLbl.Text = "Product Stock: ";
            // 
            // ProductPriceLbl
            // 
            this.ProductPriceLbl.AutoSize = true;
            this.ProductPriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ProductPriceLbl.Location = new System.Drawing.Point(275, 88);
            this.ProductPriceLbl.Name = "ProductPriceLbl";
            this.ProductPriceLbl.Size = new System.Drawing.Size(121, 20);
            this.ProductPriceLbl.TabIndex = 23;
            this.ProductPriceLbl.Text = "Product Price: ";
            // 
            // ProductNameLbl
            // 
            this.ProductNameLbl.AutoSize = true;
            this.ProductNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ProductNameLbl.Location = new System.Drawing.Point(275, 42);
            this.ProductNameLbl.Name = "ProductNameLbl";
            this.ProductNameLbl.Size = new System.Drawing.Size(126, 20);
            this.ProductNameLbl.TabIndex = 22;
            this.ProductNameLbl.Text = "Product Name: ";
            // 
            // AddCartProductBtn
            // 
            this.AddCartProductBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.AddCartProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddCartProductBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddCartProductBtn.ForeColor = System.Drawing.Color.White;
            this.AddCartProductBtn.Location = new System.Drawing.Point(279, 243);
            this.AddCartProductBtn.Name = "AddCartProductBtn";
            this.AddCartProductBtn.Size = new System.Drawing.Size(177, 43);
            this.AddCartProductBtn.TabIndex = 15;
            this.AddCartProductBtn.Text = "Add Cart";
            this.AddCartProductBtn.UseVisualStyleBackColor = false;
            this.AddCartProductBtn.Click += new System.EventHandler(this.AddCartProductBtn_Click);
            // 
            // cartProductImg
            // 
            this.cartProductImg.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cartProductImg.Location = new System.Drawing.Point(34, 42);
            this.cartProductImg.Name = "cartProductImg";
            this.cartProductImg.Size = new System.Drawing.Size(177, 152);
            this.cartProductImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cartProductImg.TabIndex = 16;
            this.cartProductImg.TabStop = false;
            // 
            // addToCartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 401);
            this.Controls.Add(this.groupBox1);
            this.Name = "addToCartForm";
            this.Text = "addToCartForm";
            this.Load += new System.EventHandler(this.addToCartForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductQuantityNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartProductImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox cartProductImg;
        private System.Windows.Forms.Button AddCartProductBtn;
        private System.Windows.Forms.Label ProductCategoryLbl;
        private System.Windows.Forms.Label ProductStockLbl;
        private System.Windows.Forms.Label ProductPriceLbl;
        private System.Windows.Forms.Label ProductNameLbl;
        private System.Windows.Forms.NumericUpDown ProductQuantityNud;
        private System.Windows.Forms.Label label1;
    }
}
namespace MarketYönetimSistemi
{
    partial class AddProductForm
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
            this.addCategoryStockNud = new System.Windows.Forms.NumericUpDown();
            this.addCategoryPriceNud = new System.Windows.Forms.NumericUpDown();
            this.addCategoryCb = new System.Windows.Forms.ComboBox();
            this.addCategoryStatusCb = new System.Windows.Forms.CheckBox();
            this.ProductImg = new System.Windows.Forms.PictureBox();
            this.AddCategoryBtn = new System.Windows.Forms.Button();
            this.CategorySelectImageBtn = new System.Windows.Forms.Button();
            this.addCategoryDescTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addCategoryNameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addCategoryStockNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addCategoryPriceNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductImg)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addCategoryStockNud);
            this.groupBox1.Controls.Add(this.addCategoryPriceNud);
            this.groupBox1.Controls.Add(this.addCategoryCb);
            this.groupBox1.Controls.Add(this.addCategoryStatusCb);
            this.groupBox1.Controls.Add(this.ProductImg);
            this.groupBox1.Controls.Add(this.AddCategoryBtn);
            this.groupBox1.Controls.Add(this.CategorySelectImageBtn);
            this.groupBox1.Controls.Add(this.addCategoryDescTxt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.addCategoryNameTxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(71, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 383);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "add User";
            // 
            // addCategoryStockNud
            // 
            this.addCategoryStockNud.Location = new System.Drawing.Point(15, 165);
            this.addCategoryStockNud.Name = "addCategoryStockNud";
            this.addCategoryStockNud.Size = new System.Drawing.Size(121, 22);
            this.addCategoryStockNud.TabIndex = 22;
            // 
            // addCategoryPriceNud
            // 
            this.addCategoryPriceNud.DecimalPlaces = 2;
            this.addCategoryPriceNud.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.addCategoryPriceNud.Location = new System.Drawing.Point(15, 101);
            this.addCategoryPriceNud.Name = "addCategoryPriceNud";
            this.addCategoryPriceNud.Size = new System.Drawing.Size(121, 22);
            this.addCategoryPriceNud.TabIndex = 21;
            // 
            // addCategoryCb
            // 
            this.addCategoryCb.FormattingEnabled = true;
            this.addCategoryCb.Location = new System.Drawing.Point(15, 304);
            this.addCategoryCb.Name = "addCategoryCb";
            this.addCategoryCb.Size = new System.Drawing.Size(121, 24);
            this.addCategoryCb.TabIndex = 19;
            // 
            // addCategoryStatusCb
            // 
            this.addCategoryStatusCb.AutoSize = true;
            this.addCategoryStatusCb.Location = new System.Drawing.Point(166, 79);
            this.addCategoryStatusCb.Name = "addCategoryStatusCb";
            this.addCategoryStatusCb.Size = new System.Drawing.Size(66, 20);
            this.addCategoryStatusCb.TabIndex = 18;
            this.addCategoryStatusCb.Text = "Status";
            this.addCategoryStatusCb.UseVisualStyleBackColor = true;
            // 
            // ProductImg
            // 
            this.ProductImg.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ProductImg.Location = new System.Drawing.Point(166, 105);
            this.ProductImg.Name = "ProductImg";
            this.ProductImg.Size = new System.Drawing.Size(136, 109);
            this.ProductImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProductImg.TabIndex = 16;
            this.ProductImg.TabStop = false;
            // 
            // AddCategoryBtn
            // 
            this.AddCategoryBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.AddCategoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddCategoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddCategoryBtn.ForeColor = System.Drawing.Color.White;
            this.AddCategoryBtn.Location = new System.Drawing.Point(166, 234);
            this.AddCategoryBtn.Name = "AddCategoryBtn";
            this.AddCategoryBtn.Size = new System.Drawing.Size(138, 43);
            this.AddCategoryBtn.TabIndex = 15;
            this.AddCategoryBtn.Text = "Add";
            this.AddCategoryBtn.UseVisualStyleBackColor = false;
            this.AddCategoryBtn.Click += new System.EventHandler(this.AddCategoryBtn_Click);
            // 
            // CategorySelectImageBtn
            // 
            this.CategorySelectImageBtn.Location = new System.Drawing.Point(164, 29);
            this.CategorySelectImageBtn.Name = "CategorySelectImageBtn";
            this.CategorySelectImageBtn.Size = new System.Drawing.Size(138, 33);
            this.CategorySelectImageBtn.TabIndex = 14;
            this.CategorySelectImageBtn.Text = "Select İmage";
            this.CategorySelectImageBtn.UseVisualStyleBackColor = true;
            this.CategorySelectImageBtn.Click += new System.EventHandler(this.CategorySelectImageBtn_Click);
            // 
            // addCategoryDescTxt
            // 
            this.addCategoryDescTxt.Location = new System.Drawing.Point(15, 231);
            this.addCategoryDescTxt.Name = "addCategoryDescTxt";
            this.addCategoryDescTxt.Size = new System.Drawing.Size(121, 22);
            this.addCategoryDescTxt.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Stock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price";
            // 
            // addCategoryNameTxt
            // 
            this.addCategoryNameTxt.Location = new System.Drawing.Point(15, 40);
            this.addCategoryNameTxt.Name = "addCategoryNameTxt";
            this.addCategoryNameTxt.Size = new System.Drawing.Size(121, 22);
            this.addCategoryNameTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 434);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddProductForm";
            this.Text = "addProductForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddProductForm_FormClosed);
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addCategoryStockNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addCategoryPriceNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox addCategoryCb;
        private System.Windows.Forms.CheckBox addCategoryStatusCb;
        private System.Windows.Forms.PictureBox ProductImg;
        private System.Windows.Forms.Button AddCategoryBtn;
        private System.Windows.Forms.Button CategorySelectImageBtn;
        private System.Windows.Forms.TextBox addCategoryDescTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addCategoryNameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown addCategoryStockNud;
        private System.Windows.Forms.NumericUpDown addCategoryPriceNud;
    }
}
namespace MarketYönetimSistemi
{
    partial class AdminForm
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
            this.AddUserBtn = new System.Windows.Forms.Button();
            this.AddProductBtn = new System.Windows.Forms.Button();
            this.UpdateProductBtn = new System.Windows.Forms.Button();
            this.UserListDgv = new System.Windows.Forms.DataGridView();
            this.ProductListDgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DeleteProductBtn = new System.Windows.Forms.Button();
            this.UserEditBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UserListDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductListDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // AddUserBtn
            // 
            this.AddUserBtn.Location = new System.Drawing.Point(12, 37);
            this.AddUserBtn.Name = "AddUserBtn";
            this.AddUserBtn.Size = new System.Drawing.Size(89, 23);
            this.AddUserBtn.TabIndex = 0;
            this.AddUserBtn.Text = "Yeni Kullanıcı Ekle";
            this.AddUserBtn.UseVisualStyleBackColor = true;
            this.AddUserBtn.Click += new System.EventHandler(this.AddUserBtn_Click);
            // 
            // AddProductBtn
            // 
            this.AddProductBtn.Location = new System.Drawing.Point(12, 85);
            this.AddProductBtn.Name = "AddProductBtn";
            this.AddProductBtn.Size = new System.Drawing.Size(89, 23);
            this.AddProductBtn.TabIndex = 1;
            this.AddProductBtn.Text = "Yeni Ürün Ekle";
            this.AddProductBtn.UseVisualStyleBackColor = true;
            this.AddProductBtn.Click += new System.EventHandler(this.AddProductBtn_Click);
            // 
            // UpdateProductBtn
            // 
            this.UpdateProductBtn.Location = new System.Drawing.Point(627, 344);
            this.UpdateProductBtn.Name = "UpdateProductBtn";
            this.UpdateProductBtn.Size = new System.Drawing.Size(122, 23);
            this.UpdateProductBtn.TabIndex = 2;
            this.UpdateProductBtn.Text = "Seçili Ürünü Güncelle";
            this.UpdateProductBtn.UseVisualStyleBackColor = true;
            this.UpdateProductBtn.Click += new System.EventHandler(this.UpdateProductBtn_Click);
            // 
            // UserListDgv
            // 
            this.UserListDgv.AllowUserToAddRows = false;
            this.UserListDgv.AllowUserToDeleteRows = false;
            this.UserListDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserListDgv.Location = new System.Drawing.Point(164, 69);
            this.UserListDgv.Name = "UserListDgv";
            this.UserListDgv.ReadOnly = true;
            this.UserListDgv.Size = new System.Drawing.Size(420, 269);
            this.UserListDgv.TabIndex = 3;
            this.UserListDgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserListDgv_CellDoubleClick);
            // 
            // ProductListDgv
            // 
            this.ProductListDgv.AllowUserToAddRows = false;
            this.ProductListDgv.AllowUserToDeleteRows = false;
            this.ProductListDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductListDgv.Location = new System.Drawing.Point(627, 69);
            this.ProductListDgv.Name = "ProductListDgv";
            this.ProductListDgv.ReadOnly = true;
            this.ProductListDgv.Size = new System.Drawing.Size(420, 269);
            this.ProductListDgv.TabIndex = 4;
            this.ProductListDgv.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductListDgv_CellContentDoubleClick);
            this.ProductListDgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductListDgv_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kullanıcı Listesi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(636, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ürün Listesi";
            // 
            // DeleteProductBtn
            // 
            this.DeleteProductBtn.Location = new System.Drawing.Point(958, 344);
            this.DeleteProductBtn.Name = "DeleteProductBtn";
            this.DeleteProductBtn.Size = new System.Drawing.Size(89, 23);
            this.DeleteProductBtn.TabIndex = 7;
            this.DeleteProductBtn.Text = "Seçili Ürünü Sil";
            this.DeleteProductBtn.UseVisualStyleBackColor = true;
            this.DeleteProductBtn.Click += new System.EventHandler(this.DeleteProductBtn_Click);
            // 
            // UserEditBtn
            // 
            this.UserEditBtn.Location = new System.Drawing.Point(164, 344);
            this.UserEditBtn.Name = "UserEditBtn";
            this.UserEditBtn.Size = new System.Drawing.Size(139, 23);
            this.UserEditBtn.TabIndex = 8;
            this.UserEditBtn.Text = "Seçili Kullanıcıyı Güncelle";
            this.UserEditBtn.UseVisualStyleBackColor = true;
            this.UserEditBtn.Click += new System.EventHandler(this.UserEditBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(475, 344);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Seçili Kullanıcıyı Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1293, 653);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.UserEditBtn);
            this.Controls.Add(this.DeleteProductBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductListDgv);
            this.Controls.Add(this.UserListDgv);
            this.Controls.Add(this.UpdateProductBtn);
            this.Controls.Add(this.AddProductBtn);
            this.Controls.Add(this.AddUserBtn);
            this.Name = "AdminForm";
            this.Text = "Admin Panel";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserListDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductListDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddUserBtn;
        private System.Windows.Forms.Button AddProductBtn;
        private System.Windows.Forms.Button UpdateProductBtn;
        private System.Windows.Forms.DataGridView UserListDgv;
        private System.Windows.Forms.DataGridView ProductListDgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DeleteProductBtn;
        private System.Windows.Forms.Button UserEditBtn;
        private System.Windows.Forms.Button button2;
    }
}
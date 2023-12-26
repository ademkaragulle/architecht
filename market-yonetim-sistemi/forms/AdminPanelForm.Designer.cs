namespace MarketYönetimSistemi
{
    partial class AdminPanelForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.categoryDgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.AddCategoryBtn = new System.Windows.Forms.Button();
            this.addProductBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.productDgv = new System.Windows.Forms.DataGridView();
            this.AddCustomerBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.customerDgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // categoryDgv
            // 
            this.categoryDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryDgv.GridColor = System.Drawing.Color.Black;
            this.categoryDgv.Location = new System.Drawing.Point(31, 66);
            this.categoryDgv.Name = "categoryDgv";
            this.categoryDgv.RowHeadersWidth = 51;
            this.categoryDgv.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.categoryDgv.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.categoryDgv.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.categoryDgv.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.categoryDgv.RowTemplate.Height = 24;
            this.categoryDgv.Size = new System.Drawing.Size(315, 438);
            this.categoryDgv.TabIndex = 0;
            this.categoryDgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.categoryDgv_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(27, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Category List";
            // 
            // AddCategoryBtn
            // 
            this.AddCategoryBtn.BackColor = System.Drawing.Color.Red;
            this.AddCategoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddCategoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddCategoryBtn.Location = new System.Drawing.Point(176, 21);
            this.AddCategoryBtn.Name = "AddCategoryBtn";
            this.AddCategoryBtn.Size = new System.Drawing.Size(170, 39);
            this.AddCategoryBtn.TabIndex = 2;
            this.AddCategoryBtn.Text = "Add Category";
            this.AddCategoryBtn.UseVisualStyleBackColor = false;
            this.AddCategoryBtn.Click += new System.EventHandler(this.AddCategoryBtn_Click);
            // 
            // addProductBtn
            // 
            this.addProductBtn.BackColor = System.Drawing.Color.Red;
            this.addProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addProductBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addProductBtn.Location = new System.Drawing.Point(672, 21);
            this.addProductBtn.Name = "addProductBtn";
            this.addProductBtn.Size = new System.Drawing.Size(170, 39);
            this.addProductBtn.TabIndex = 5;
            this.addProductBtn.Text = "Add Product";
            this.addProductBtn.UseVisualStyleBackColor = false;
            this.addProductBtn.Click += new System.EventHandler(this.addProductBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(366, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Product List";
            // 
            // productDgv
            // 
            this.productDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDgv.GridColor = System.Drawing.Color.Black;
            this.productDgv.Location = new System.Drawing.Point(370, 66);
            this.productDgv.Name = "productDgv";
            this.productDgv.RowHeadersWidth = 51;
            this.productDgv.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.productDgv.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.productDgv.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.productDgv.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.productDgv.RowTemplate.Height = 24;
            this.productDgv.Size = new System.Drawing.Size(472, 438);
            this.productDgv.TabIndex = 3;
            this.productDgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productDgv_CellDoubleClick);
            // 
            // AddCustomerBtn
            // 
            this.AddCustomerBtn.BackColor = System.Drawing.Color.Red;
            this.AddCustomerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddCustomerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddCustomerBtn.Location = new System.Drawing.Point(1171, 21);
            this.AddCustomerBtn.Name = "AddCustomerBtn";
            this.AddCustomerBtn.Size = new System.Drawing.Size(170, 39);
            this.AddCustomerBtn.TabIndex = 8;
            this.AddCustomerBtn.Text = "Add Customer";
            this.AddCustomerBtn.UseVisualStyleBackColor = false;
            this.AddCustomerBtn.Click += new System.EventHandler(this.AddCustomerBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(865, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Customer List";
            // 
            // customerDgv
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.customerDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDgv.Location = new System.Drawing.Point(869, 66);
            this.customerDgv.MultiSelect = false;
            this.customerDgv.Name = "customerDgv";
            this.customerDgv.RowHeadersWidth = 51;
            this.customerDgv.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.customerDgv.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.customerDgv.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.customerDgv.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.customerDgv.RowTemplate.Height = 24;
            this.customerDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerDgv.Size = new System.Drawing.Size(470, 437);
            this.customerDgv.TabIndex = 9;
            this.customerDgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerDgv_CellDoubleClick);
            // 
            // AdminPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 538);
            this.Controls.Add(this.customerDgv);
            this.Controls.Add(this.AddCustomerBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addProductBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productDgv);
            this.Controls.Add(this.AddCategoryBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.categoryDgv);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "AdminPanelForm";
            this.Text = "AdminPanelForm";
            this.Load += new System.EventHandler(this.AdminPanelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView categoryDgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddCategoryBtn;
        private System.Windows.Forms.Button addProductBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView productDgv;
        private System.Windows.Forms.Button AddCustomerBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView customerDgv;
    }
}
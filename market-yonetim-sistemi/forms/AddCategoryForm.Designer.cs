namespace MarketYönetimSistemi
{
    partial class AddCategoryForm
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
            this.addCategoryStatusCb = new System.Windows.Forms.CheckBox();
            this.CategoryImg = new System.Windows.Forms.PictureBox();
            this.AddUserBtn = new System.Windows.Forms.Button();
            this.CategorySelectImageBtn = new System.Windows.Forms.Button();
            this.addCategoryDescTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addCategoryNameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryImg)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addCategoryStatusCb);
            this.groupBox1.Controls.Add(this.CategoryImg);
            this.groupBox1.Controls.Add(this.AddUserBtn);
            this.groupBox1.Controls.Add(this.CategorySelectImageBtn);
            this.groupBox1.Controls.Add(this.addCategoryDescTxt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.addCategoryNameTxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(32, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 283);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "add Category";
            // 
            // addCategoryStatusCb
            // 
            this.addCategoryStatusCb.AutoSize = true;
            this.addCategoryStatusCb.Location = new System.Drawing.Point(35, 211);
            this.addCategoryStatusCb.Name = "addCategoryStatusCb";
            this.addCategoryStatusCb.Size = new System.Drawing.Size(66, 20);
            this.addCategoryStatusCb.TabIndex = 18;
            this.addCategoryStatusCb.Text = "Status";
            this.addCategoryStatusCb.UseVisualStyleBackColor = true;
            // 
            // CategoryImg
            // 
            this.CategoryImg.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CategoryImg.Location = new System.Drawing.Point(202, 83);
            this.CategoryImg.Name = "CategoryImg";
            this.CategoryImg.Size = new System.Drawing.Size(138, 109);
            this.CategoryImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CategoryImg.TabIndex = 16;
            this.CategoryImg.TabStop = false;
            // 
            // AddUserBtn
            // 
            this.AddUserBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.AddUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddUserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddUserBtn.ForeColor = System.Drawing.Color.White;
            this.AddUserBtn.Location = new System.Drawing.Point(200, 198);
            this.AddUserBtn.Name = "AddUserBtn";
            this.AddUserBtn.Size = new System.Drawing.Size(140, 43);
            this.AddUserBtn.TabIndex = 15;
            this.AddUserBtn.Text = "Add";
            this.AddUserBtn.UseVisualStyleBackColor = false;
            this.AddUserBtn.Click += new System.EventHandler(this.AddUserBtn_Click);
            // 
            // CategorySelectImageBtn
            // 
            this.CategorySelectImageBtn.Location = new System.Drawing.Point(202, 44);
            this.CategorySelectImageBtn.Name = "CategorySelectImageBtn";
            this.CategorySelectImageBtn.Size = new System.Drawing.Size(138, 33);
            this.CategorySelectImageBtn.TabIndex = 14;
            this.CategorySelectImageBtn.Text = "Select İmage";
            this.CategorySelectImageBtn.UseVisualStyleBackColor = true;
            this.CategorySelectImageBtn.Click += new System.EventHandler(this.CategorySelectImageBtn_Click);
            // 
            // addCategoryDescTxt
            // 
            this.addCategoryDescTxt.Location = new System.Drawing.Point(35, 146);
            this.addCategoryDescTxt.Name = "addCategoryDescTxt";
            this.addCategoryDescTxt.Size = new System.Drawing.Size(121, 22);
            this.addCategoryDescTxt.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Description";
            // 
            // addCategoryNameTxt
            // 
            this.addCategoryNameTxt.Location = new System.Drawing.Point(35, 63);
            this.addCategoryNameTxt.Name = "addCategoryNameTxt";
            this.addCategoryNameTxt.Size = new System.Drawing.Size(121, 22);
            this.addCategoryNameTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // AddCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 386);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddCategoryForm";
            this.Text = "AddCategoryForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddCategoryForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox addCategoryStatusCb;
        private System.Windows.Forms.Button AddUserBtn;
        private System.Windows.Forms.Button CategorySelectImageBtn;
        private System.Windows.Forms.TextBox addCategoryDescTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox addCategoryNameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox CategoryImg;
    }
}
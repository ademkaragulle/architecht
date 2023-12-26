namespace MarketYönetimSistemi
{
    partial class UpdateCategory
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
            this.deleteAddCategoryBtn = new System.Windows.Forms.Button();
            this.updateCategoryStatusCb = new System.Windows.Forms.CheckBox();
            this.updateCategoryImg = new System.Windows.Forms.PictureBox();
            this.updateAddCategoryBtn = new System.Windows.Forms.Button();
            this.updateCategorySelectImageBtn = new System.Windows.Forms.Button();
            this.updateCategoryDescTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.updateCategoryNameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updateCategoryImg)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deleteAddCategoryBtn);
            this.groupBox1.Controls.Add(this.updateCategoryStatusCb);
            this.groupBox1.Controls.Add(this.updateCategoryImg);
            this.groupBox1.Controls.Add(this.updateAddCategoryBtn);
            this.groupBox1.Controls.Add(this.updateCategorySelectImageBtn);
            this.groupBox1.Controls.Add(this.updateCategoryDescTxt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.updateCategoryNameTxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 283);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "update Category";
            // 
            // deleteAddCategoryBtn
            // 
            this.deleteAddCategoryBtn.BackColor = System.Drawing.Color.Red;
            this.deleteAddCategoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteAddCategoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deleteAddCategoryBtn.ForeColor = System.Drawing.Color.White;
            this.deleteAddCategoryBtn.Location = new System.Drawing.Point(35, 198);
            this.deleteAddCategoryBtn.Name = "deleteAddCategoryBtn";
            this.deleteAddCategoryBtn.Size = new System.Drawing.Size(121, 55);
            this.deleteAddCategoryBtn.TabIndex = 19;
            this.deleteAddCategoryBtn.Text = "Delete ";
            this.deleteAddCategoryBtn.UseVisualStyleBackColor = false;
            this.deleteAddCategoryBtn.Click += new System.EventHandler(this.deleteAddCategoryBtn_Click);
            // 
            // updateCategoryStatusCb
            // 
            this.updateCategoryStatusCb.AutoSize = true;
            this.updateCategoryStatusCb.Location = new System.Drawing.Point(35, 156);
            this.updateCategoryStatusCb.Name = "updateCategoryStatusCb";
            this.updateCategoryStatusCb.Size = new System.Drawing.Size(66, 20);
            this.updateCategoryStatusCb.TabIndex = 18;
            this.updateCategoryStatusCb.Text = "Status";
            this.updateCategoryStatusCb.UseVisualStyleBackColor = true;
            // 
            // updateCategoryImg
            // 
            this.updateCategoryImg.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.updateCategoryImg.Location = new System.Drawing.Point(202, 83);
            this.updateCategoryImg.Name = "updateCategoryImg";
            this.updateCategoryImg.Size = new System.Drawing.Size(138, 109);
            this.updateCategoryImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.updateCategoryImg.TabIndex = 16;
            this.updateCategoryImg.TabStop = false;
            // 
            // updateAddCategoryBtn
            // 
            this.updateAddCategoryBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.updateAddCategoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateAddCategoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.updateAddCategoryBtn.ForeColor = System.Drawing.Color.White;
            this.updateAddCategoryBtn.Location = new System.Drawing.Point(200, 198);
            this.updateAddCategoryBtn.Name = "updateAddCategoryBtn";
            this.updateAddCategoryBtn.Size = new System.Drawing.Size(140, 55);
            this.updateAddCategoryBtn.TabIndex = 15;
            this.updateAddCategoryBtn.Text = "Update";
            this.updateAddCategoryBtn.UseVisualStyleBackColor = false;
            this.updateAddCategoryBtn.Click += new System.EventHandler(this.updateAddCategoryBtn_Click);
            // 
            // updateCategorySelectImageBtn
            // 
            this.updateCategorySelectImageBtn.Location = new System.Drawing.Point(202, 44);
            this.updateCategorySelectImageBtn.Name = "updateCategorySelectImageBtn";
            this.updateCategorySelectImageBtn.Size = new System.Drawing.Size(138, 33);
            this.updateCategorySelectImageBtn.TabIndex = 14;
            this.updateCategorySelectImageBtn.Text = "Select İmage";
            this.updateCategorySelectImageBtn.UseVisualStyleBackColor = true;
            this.updateCategorySelectImageBtn.Click += new System.EventHandler(this.updateCategorySelectImageBtn_Click);
            // 
            // updateCategoryDescTxt
            // 
            this.updateCategoryDescTxt.Location = new System.Drawing.Point(35, 119);
            this.updateCategoryDescTxt.Name = "updateCategoryDescTxt";
            this.updateCategoryDescTxt.Size = new System.Drawing.Size(121, 22);
            this.updateCategoryDescTxt.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Description";
            // 
            // updateCategoryNameTxt
            // 
            this.updateCategoryNameTxt.Location = new System.Drawing.Point(35, 63);
            this.updateCategoryNameTxt.Name = "updateCategoryNameTxt";
            this.updateCategoryNameTxt.Size = new System.Drawing.Size(121, 22);
            this.updateCategoryNameTxt.TabIndex = 1;
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
            // UpdateCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 386);
            this.Controls.Add(this.groupBox1);
            this.Name = "UpdateCategory";
            this.Text = "UpdateCategory";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UpdateCategory_FormClosed);
            this.Load += new System.EventHandler(this.UpdateCategory_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updateCategoryImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox updateCategoryStatusCb;
        private System.Windows.Forms.PictureBox updateCategoryImg;
        private System.Windows.Forms.Button updateAddCategoryBtn;
        private System.Windows.Forms.Button updateCategorySelectImageBtn;
        private System.Windows.Forms.TextBox updateCategoryDescTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox updateCategoryNameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteAddCategoryBtn;
    }
}
namespace MarketYönetimSistemi.forms
{
    partial class Siparişlerim
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
            this.orderDgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orderDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // orderDgv
            // 
            this.orderDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDgv.Location = new System.Drawing.Point(32, 85);
            this.orderDgv.Name = "orderDgv";
            this.orderDgv.RowHeadersWidth = 51;
            this.orderDgv.RowTemplate.Height = 24;
            this.orderDgv.Size = new System.Drawing.Size(700, 311);
            this.orderDgv.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(294, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Siparişlerim";
            // 
            // Siparişlerim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 430);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orderDgv);
            this.Name = "Siparişlerim";
            this.Text = "Siparişlerim";
            this.Load += new System.EventHandler(this.Siparişlerim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView orderDgv;
        private System.Windows.Forms.Label label1;
    }
}
using MarketYönetimSistemi.Controller;
using MarketYönetimSistemi.Entity;
using MarketYönetimSistemi.Entity.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketYönetimSistemi
{
    public partial class UpdateProductForm : Form
    {
        ProductCrud productCrud = new ProductCrud();
        FunctionsCommon functions = new FunctionsCommon();
        int updateProductId = AdminPanelForm.updateProductId;
        public UpdateProductForm()
        {
            InitializeComponent();
        }

        private void UpdateProductForm_Load(object sender, EventArgs e)
        {
            functions.getCategoryToCb(updateProductCategoryCb);


            var product = productCrud.GetById(updateProductId);
            updateProductNameTxt.Text += product.Name;
            updateProductPriceTxt.Value = (decimal)product.Price;
            updateProductStockTxt.Text += product.Stock;
            updateProductDescTxt.Text = product.Description;
            updateProductCategoryCb.SelectedItem = product.CategoryId;
            updateProductStatusCb.Checked = product.IsStatus;
            UpdateProductImg.ImageLocation = product.Image;
        }

        private void UpdateProductBtn_Click(object sender, EventArgs e)
        {

            Product product = new Product();

            product.Name = updateProductNameTxt.Text;
            product.Price = Convert.ToDouble(updateProductPriceTxt.Text);
            product.Stock = Convert.ToInt32(updateProductStockTxt.Value);
            product.Description = updateProductDescTxt.Text;
            product.CategoryId = Convert.ToInt32(updateProductCategoryCb.SelectedValue);
            product.IsStatus = updateProductStatusCb.Checked;
            product.Image = UpdateProductImg.ImageLocation;

            DialogResult addQuestion = MessageBox.Show("Product güncellensin mi", "Güncelleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (addQuestion == DialogResult.Yes)
            {
                MessageBox.Show(productCrud.Update(product, updateProductId) ?
                                "Kayıt başarılı." :
                                "Kayıt başarısız.");
                updateProductNameTxt.Clear();
                updateProductPriceTxt.Value = 0;
                updateProductStockTxt.Value = 0;
                updateProductDescTxt.Clear();
                updateProductStatusCb.Checked = false;
                UpdateProductImg.ImageLocation = null;
            }
            else
            {
                MessageBox.Show("ekleme işlemi iptal edildi");
            }
        }

        private void UpdateProductForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminPanelForm adminForm = (AdminPanelForm)Application.OpenForms["AdminPanelForm"];
            adminForm.LoadForm();
        }

        private void DeleteProductBtn_Click(object sender, EventArgs e)
        {
            bool result = productCrud.Delete(updateProductId);
            MessageBox.Show(result ? "this category deleted" : "this category is not deleted");
        }


    }
}

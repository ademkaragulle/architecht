using MarketYönetimSistemi.Controller;
using MarketYönetimSistemi.Entity;
using MarketYönetimSistemi.Entity.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketYönetimSistemi
{
    public partial class AddProductForm : Form
    {
        FunctionsCommon functions = new FunctionsCommon();
        ProductCrud productCrud = new ProductCrud();
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void AddCategoryBtn_Click(object sender, EventArgs e)
        {
            DialogResult addQuestion = MessageBox.Show("Product eklensin mi", "Product ekleme ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (addQuestion == DialogResult.Yes)
            {
                Product product = new Product();
                product.Name = addCategoryNameTxt.Text;
                product.Price = Convert.ToDouble(addCategoryPriceNud.Value);
                product.Stock = Convert.ToInt32(addCategoryStockNud.Value);
                product.Description = addCategoryDescTxt.Text;
                product.CategoryId = Convert.ToInt32(addCategoryCb.SelectedValue);
                product.IsStatus = addCategoryStatusCb.Checked;


                string ımagePath = @"C:\Users\ADEMKARAGÜLLE\Desktop\MarketYönetimSistemi\images\";
                string userImage = "";
                string defaultImage = "emptyRole.jpg";

                if (ProductImg.Image != null)
                {
                    string ImageName = Guid.NewGuid() + ".jpg";
                    ProductImg.Image.Save(ımagePath + ImageName, ImageFormat.Jpeg);
                    userImage = ımagePath + ImageName;
                }
                else
                {
                    userImage = ımagePath + defaultImage;
                }
                product.Image = userImage;

                MessageBox.Show(productCrud.Add(product) ?
                                "Kayıt başarılı." :
                                "Kayıt başarısız.");
                addCategoryNameTxt.Clear();
                addCategoryPriceNud.Value = 0;
                addCategoryStockNud.Value = 0;
                addCategoryDescTxt.Clear();
                addCategoryStatusCb.Checked = false;
                ProductImg.Image = null;
            }
            else
            {
                MessageBox.Show("ekleme işlemi iptal edildi");

            }
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            functions.getCategoryToCb(addCategoryCb);
        }

        private void AddProductForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminPanelForm adminForm = (AdminPanelForm)Application.OpenForms["AdminPanelForm"];
            adminForm.LoadForm();
        }

        private void CategorySelectImageBtn_Click(object sender, EventArgs e)
        {
            functions.UploadPictureBoxImage(ProductImg);
        }
    }
}

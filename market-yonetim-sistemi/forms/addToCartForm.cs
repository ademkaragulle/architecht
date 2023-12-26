using MarketYönetimSistemi.Entity;
using MarketYönetimSistemi.Entity.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketYönetimSistemi.Controller
{
    public partial class addToCartForm : Form
    {

        ProductCrud productCrud = new ProductCrud();
        CategoryCrud categoryCrud = new CategoryCrud();
        BuyCrud buyCrud = new BuyCrud();
        int ProductId = UserPanelForm.ProductId;
        public addToCartForm()
        {
            InitializeComponent();
        }

        private void addToCartForm_Load(object sender, EventArgs e)
        {
            Product product = productCrud.GetById(ProductId);
            Category category = categoryCrud.GetById(product.CategoryId);
            cartProductImg.ImageLocation = product.Image;
            ProductNameLbl.Text += product.Name;
            ProductPriceLbl.Text += product.Price;
            ProductStockLbl.Text += product.Stock;
            ProductCategoryLbl.Text += category.Name;
        }

        private void AddCartProductBtn_Click(object sender, EventArgs e)
        {
            BuyProduct product = new BuyProduct();
            int productQArray = Convert.ToInt32(ProductQuantityNud.Value);

            product.UserId = Form1.currentUser;
            product.ProductId = ProductId;
            product.Quantity = productQArray;


            if (product.Quantity > productCrud.GetById(ProductId).Stock)
            {
                MessageBox.Show("Ürünün bu kadar stoğu yok eklediğiniz ürün miktarını kontrol edin.");
            }
            else
            {
                buyCrud.Add(product);
                MessageBox.Show("Ürün Başarıyla Sepete Eklendi.");
                this.Close();

                deleteStock(productQArray);
            }
        }
        public void deleteStock(int Quantity)
        {
            Product product = productCrud.GetById(ProductId);
            product.Stock -= Quantity;

            productCrud.Update(product, product.Id);
        }
    }
}

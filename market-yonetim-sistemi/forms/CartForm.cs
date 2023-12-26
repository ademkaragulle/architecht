using MarketYönetimSistemi.Controller;
using MarketYönetimSistemi.Entity;
using MarketYönetimSistemi.Entity.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketYönetimSistemi.forms
{
    public partial class CartForm : Form
    {
        ProductCrud productCrud = new ProductCrud();
        BuyCrud buyCrud = new BuyCrud();
        SellCrud sellCrud = new SellCrud();
        OrderCrud orderCrud = new OrderCrud();
        public CartForm()
        {
            InitializeComponent();
        }

        private void CartForm_Load(object sender, EventArgs e)
        {
            CartDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            LoadForm();
        }


        private void BuyToCartBtn_Click(object sender, EventArgs e)
        {
            DialogResult AddQuestion = MessageBox.Show("Sepeti Onaylamak İstiyor musunuz?", "Sepeti Onayla", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (AddQuestion == DialogResult.Yes)
            {
                var order = new Order();
                order.UserId = Form1.currentUser;
                order.OrderDateTine = DateTime.Now;
                orderCrud.Add(order);
                var items = buyCrud.GetAll().Where(x => x.UserId == Form1.currentUser).ToList();
                foreach (var item in items)
                {
                    SellProduct sellProduct = new SellProduct();
                    sellProduct.OrderId = order.Id;
                    sellProduct.ProductId = item.ProductId;
                    sellProduct.Quantity = item.Quantity;
                    sellProduct.TotalPrice = productCrud.GetById(item.ProductId).Price * item.Quantity;
                    sellProduct.Price = productCrud.GetById(item.ProductId).Price;

                    Product product = new Product();
                    product.Name = productCrud.GetById(item.ProductId).Name;
                    product.Price = productCrud.GetById(item.ProductId).Price;
                    product.Stock = productCrud.GetById(item.ProductId).Stock - item.Quantity;
                    product.CategoryId = productCrud.GetById(item.ProductId).CategoryId;
                    product.Description = productCrud.GetById(item.ProductId).Description;
                    product.IsStatus = productCrud.GetById(item.ProductId).IsStatus;
                    product.Image = productCrud.GetById(item.ProductId).Image;
                    if (product.Stock == 0)
                    {
                        product.IsStatus = false;
                    }
                    productCrud.Update(product, item.ProductId);
                    sellCrud.Add(sellProduct);
                    buyCrud.Delete(item.Id);



                }
                MessageBox.Show("Ürünleri Başarıyla satın Aldınız");
            }
            LoadForm();
        }

        private void DeleteCartBtn_Click(object sender, EventArgs e)
        {
            DialogResult AddQuestion = MessageBox.Show("Sepeti Boşaltmak İstiyor musunuz?", "Sepeti Boşalt", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (AddQuestion == DialogResult.Yes)
            {
                var items = buyCrud.GetAll().Where(x => x.UserId == Form1.currentUser).ToList();

                foreach (var item in items)
                {
                    buyCrud.Delete(item.Id);

                }
                MessageBox.Show("Sepet Boşaltıldı.");
            }
            LoadForm();
        }


        private void LoadForm()
        {
            CartDgv.DataSource = buyCrud.GetAll().Where(x => x.UserId == Form1.currentUser).ToList();
            CartDgv.Columns["User"].Visible = false;
            CartDgv.Columns["UserId"].Visible = false;
            CartDgv.Columns["Product"].Visible = false;
            CartDgv.Columns[6].Visible = false;
        }
    }
}

using MarketYönetimSistemi.AdminForms;
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

namespace MarketYönetimSistemi
{
    public partial class AdminForm : Form
    {
        UserCrud userCrud = new UserCrud();
        ProductCrud productCrud = new ProductCrud();
        public static int ProductId = 0;
        public static int UserId = 0;
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            LoadForm();
            UserListDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProductListDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        public void LoadForm()
        {
            UserListDgv.DataSource = userCrud.GetAll();
            ProductListDgv.DataSource = productCrud.GetAll();
        }
        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser(this);
            addUser.ShowDialog();
        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct(this);
            addProduct.ShowDialog();
        }

        private void UpdateProductBtn_Click(object sender, EventArgs e)
        {
            ProductId = Convert.ToInt32(ProductListDgv.CurrentRow.Cells[4].Value);
            EidtProduct eidtProduct = new EidtProduct(this);
            eidtProduct.ShowDialog();

        }

        private void DeleteProductBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ProductListDgv.CurrentRow.Cells[4].Value);
            DialogResult AddQuestion = MessageBox.Show("Ürün Silinsin mi?", "Ürün Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (AddQuestion == DialogResult.Yes)
            {
                bool msg = productCrud.Delete(id);

                if (msg)
                {
                    MessageBox.Show("Ürün Başarıyla Silindi");
                    LoadForm();
                    
                }
                else
                {
                    MessageBox.Show("Ürün Silme Başarısız");
                }

            }

        }

        private void ProductListDgv_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void ProductListDgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductId = Convert.ToInt32(ProductListDgv.CurrentRow.Cells[4].Value);
            ProductDetail productDetail = new ProductDetail();
            productDetail.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(UserListDgv.CurrentRow.Cells[5].Value);
            DialogResult AddQuestion = MessageBox.Show("Kullanıcı Silinsin mi?", "Kullanıcı Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (AddQuestion == DialogResult.Yes)
            {
                bool msg = userCrud.Delete(id);

                if (msg)
                {
                    MessageBox.Show("Kullanıcı Başarıyla Silindi");
                    LoadForm();

                }
                else
                {
                    MessageBox.Show("Kullanıcı Silme Başarısız");
                }

            }


        }

        private void UserEditBtn_Click(object sender, EventArgs e)
        {
            UserId = Convert.ToInt32(UserListDgv.CurrentRow.Cells[5].Value);
           EditUser editUser = new EditUser(this);
            editUser.ShowDialog();  


        }

        private void UserListDgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UserId = Convert.ToInt32(UserListDgv.CurrentRow.Cells[5].Value);
            UserDetail userDetail = new UserDetail();
            
            userDetail.ShowDialog();    
        }
    }
}

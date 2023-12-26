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
    public partial class AdminPanelForm : Form
    {
        public static int updateCategoryId = 0;
        public static int updateProductId = 0;
        public static int updateUserId = 0;

        UserCrud userCrud = new UserCrud();
        CategoryCrud categoryCrud = new CategoryCrud();
        ProductCrud productCrud = new ProductCrud();
        public AdminPanelForm()
        {
            InitializeComponent();
        }

        private void AddCustomerBtn_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            addUserForm.ShowDialog();
        }

        private void AdminPanelForm_Load(object sender, EventArgs e)
        {
            customerDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            categoryDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            LoadForm();
        }

        public void LoadForm()
        {
            customerDgv.DataSource = userCrud.GetAll();
            categoryDgv.DataSource = categoryCrud.GetAll();
            productDgv.DataSource = productCrud.GetAll();
        }

        private void AddCategoryBtn_Click(object sender, EventArgs e)
        {
            AddCategoryForm addCategoryForm = new AddCategoryForm();
            addCategoryForm.ShowDialog();
        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.ShowDialog();
        }

        private void categoryDgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            updateCategoryId = Convert.ToInt32(categoryDgv.CurrentRow.Cells["Id"].Value);
            UpdateCategory updateCategory = new UpdateCategory();
            updateCategory.ShowDialog();
        }

        private void productDgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            updateProductId = Convert.ToInt32(productDgv.CurrentRow.Cells["Id"].Value);
            UpdateProductForm updateProductForm = new UpdateProductForm();
            updateProductForm.ShowDialog();
        }

        private void customerDgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            updateUserId = Convert.ToInt32(customerDgv.CurrentRow.Cells["Id"].Value);
            UpdateUserForm updateUserForm = new UpdateUserForm();
            updateUserForm.ShowDialog();
        }
    }
}

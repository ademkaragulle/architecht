using MarketYönetimSistemi.Controller;
using MarketYönetimSistemi.Entity;
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
    public partial class UpdateCategory : Form
    {
        CategoryCrud categoryCrud = new CategoryCrud();
        FunctionsCommon functions = new FunctionsCommon();
        int updateCategoryId = AdminPanelForm.updateCategoryId;

        public UpdateCategory()
        {
            InitializeComponent();
        }

        private void UpdateCategory_Load(object sender, EventArgs e)
        {
            var category = categoryCrud.GetById(updateCategoryId);
            updateCategoryNameTxt.Text += category.Name;
            updateCategoryDescTxt.Text = category.Description;
            updateCategoryStatusCb.Checked = category.IsStatus;
            updateCategoryImg.ImageLocation = category.Image;

        }

        private void updateAddCategoryBtn_Click(object sender, EventArgs e)
        {
            DialogResult addQuestion = MessageBox.Show("category güncellensin mi", "Güncelleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (addQuestion == DialogResult.Yes)
            {

                Category category = new Category();
                category.Name = updateCategoryNameTxt.Text;
                category.Description = updateCategoryDescTxt.Text;
                category.IsStatus = updateCategoryStatusCb.Checked;


                string ımagePath = @"C:\Users\ADEMKARAGÜLLE\Desktop\MarketYönetimSistemi\images\";
                string userImage = "";
                string defaultImage = "emptyRole.jpg";

                if (updateCategoryImg.Image != null)
                {
                    string ImageName = Guid.NewGuid() + ".jpg";
                    updateCategoryImg.Image.Save(ımagePath + ImageName, ImageFormat.Jpeg);
                    userImage = ımagePath + ImageName;
                }
                else
                {
                    userImage = ımagePath + defaultImage;
                }
                category.Image = userImage;

                MessageBox.Show(categoryCrud.Update(category, updateCategoryId) ?
                                "Kayıt başarılı." :
                                "Kayıt başarısız.");
                updateCategoryNameTxt.Clear();
                updateCategoryDescTxt.Clear();
                updateCategoryStatusCb.Checked = false;
                updateCategoryImg.Image = null;
            }
            else
            {
                MessageBox.Show("ekleme işlemi iptal edildi");
            }
        }

        private void updateCategorySelectImageBtn_Click(object sender, EventArgs e)
        {
            functions.UploadPictureBoxImage(updateCategoryImg);
        }

        private void deleteAddCategoryBtn_Click(object sender, EventArgs e)
        {
            bool result = categoryCrud.Delete(updateCategoryId);
            MessageBox.Show(result ? "this category deleted" : "this category is not deleted");
        }

        private void UpdateCategory_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminPanelForm adminForm = (AdminPanelForm)Application.OpenForms["AdminPanelForm"];
            adminForm.LoadForm();
        }
    }
}

using MarketYönetimSistemi.Controller;
using MarketYönetimSistemi.Entity;
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
    public partial class AddCategoryForm : Form
    {
        FunctionsCommon functions = new FunctionsCommon();
        CategoryCrud categoryCrud = new CategoryCrud();
        public AddCategoryForm()
        {
            InitializeComponent();
        }

        private void CategorySelectImageBtn_Click(object sender, EventArgs e)
        {
            functions.UploadPictureBoxImage(CategoryImg);
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            DialogResult addQuestion = MessageBox.Show("Category eklensin mi", "Category ekleme ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (addQuestion == DialogResult.Yes)
            {
                Category category = new Category();
                category.Name = addCategoryNameTxt.Text;
                category.Description = addCategoryDescTxt.Text;
                category.IsStatus = addCategoryStatusCb.Checked;


                string ımagePath = @"C:\Users\ADEMKARAGÜLLE\Desktop\MarketYönetimSistemi\images\";
                string userImage = "";
                string defaultImage = "emptyRole.jpg";

                if (CategoryImg.Image != null)
                {
                    string ImageName = Guid.NewGuid() + ".jpg";
                    CategoryImg.Image.Save(ımagePath + ImageName, ImageFormat.Jpeg);
                    userImage = ımagePath + ImageName;
                }
                else
                {
                    userImage = ımagePath + defaultImage;
                }
                category.Image = userImage;

                MessageBox.Show(categoryCrud.Add(category) ?
                                "Kayıt başarılı." :
                                "Kayıt başarısız.");
                addCategoryNameTxt.Clear();
                addCategoryDescTxt.Clear();
                addCategoryStatusCb.Checked = false;
                CategoryImg.Image = null;
            }
            else
            {
                MessageBox.Show("ekleme işlemi iptal edildi");
            }
        }

        private void AddCategoryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminPanelForm adminForm = (AdminPanelForm)Application.OpenForms["AdminPanelForm"];
            adminForm.LoadForm();
        }
    }
}

using MarketYönetimSistemi.Entity.Interface;
using MarketYönetimSistemi.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarketYönetimSistemi.Controller;
using System.Drawing.Imaging;

namespace MarketYönetimSistemi
{
    public partial class UpdateUserForm : Form
    {
        UserCrud userCrud = new UserCrud();
        FunctionsCommon functions = new FunctionsCommon();
        int updateUserId = AdminPanelForm.updateUserId;
        public UpdateUserForm()
        {
            InitializeComponent();
        }

        private void UpdateUserForm_Load(object sender, EventArgs e)
        {
            functions.getRoleListToCb(updateUserRoleCb);


            var user = userCrud.GetById(updateUserId);
            updateUserNameTxt.Text = user.Name;
            updateUserSurnameTxt.Text = user.Surname;
            updateUserEmailTxt.Text = user.Email;
            updateUserPasswordTxt.Text = user.Password;
            updateUserRoleCb.SelectedItem = user.RoleId;
            updateUserStatusCb.Checked = user.IsStatus;
            updateUserDescTxt.Text = user.Description;
            updateUserImg.ImageLocation = user.Image;
        }

        private void updateUserBtn_Click(object sender, EventArgs e)
        {
            User user = new User();

            user.Name = updateUserNameTxt.Text;
            user.Surname = updateUserSurnameTxt.Text;
            user.Email = updateUserEmailTxt.Text;
            user.Password = updateUserPasswordTxt.Text;
            user.RoleId = Convert.ToInt32(updateUserRoleCb.SelectedValue);
            user.IsStatus = updateUserStatusCb.Checked;
            user.Description = updateUserDescTxt.Text;


            string ımagePath = @"C:\Users\ADEMKARAGÜLLE\Desktop\MarketYönetimSistemi\images\";
            string userImage = "";
            string defaultImage = "emptyRole.jpg";

            if (updateUserImg.Image != null)
            {
                string ImageName = Guid.NewGuid() + ".jpg";
                updateUserImg.Image.Save(ımagePath + ImageName, ImageFormat.Jpeg);
                userImage = ımagePath + ImageName;
            }
            else
            {
                userImage = ımagePath + defaultImage;
            }
            user.Image = userImage;

            DialogResult addQuestion = MessageBox.Show("User güncellensin mi", "Güncelleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (addQuestion == DialogResult.Yes)
            {
                MessageBox.Show(userCrud.Update(user, updateUserId) ?
                                "Kayıt başarılı." :
                                "Kayıt başarısız.");
                updateUserNameTxt.Clear();
                updateUserSurnameTxt.Clear();
                updateUserEmailTxt.Clear();
                updateUserPasswordTxt.Clear();
                updateUserStatusCb.Checked = false;
                updateUserDescTxt.Clear(); ;
                updateUserImg.ImageLocation = null;
            }
            else
            {
                MessageBox.Show("ekleme işlemi iptal edildi");
            }
        }

        private void UpdateUserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminPanelForm adminForm = (AdminPanelForm)Application.OpenForms["AdminPanelForm"];
            adminForm.LoadForm();
        }

        private void deleteUserBtn_Click(object sender, EventArgs e)
        {
            bool result = userCrud.Delete(updateUserId);
            MessageBox.Show(result ? "this category deleted" : "this category is not deleted");

            updateUserNameTxt.Clear();
            updateUserSurnameTxt.Clear();
            updateUserEmailTxt.Clear();
            updateUserPasswordTxt.Clear();
            updateUserStatusCb.Checked = false;
            updateUserDescTxt.Clear(); ;
            updateUserImg.ImageLocation = null;
        }
    }
}

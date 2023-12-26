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
    public partial class AddUserForm : Form
    {
        FunctionsCommon functions = new FunctionsCommon();
        UserCrud userCrud = new UserCrud();
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void UserSelectImageBtn_Click(object sender, EventArgs e)
        {
            functions.UploadPictureBoxImage(UserImg);
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            DialogResult addQuestion = MessageBox.Show("User eklensin mi", "role ekleme ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (addQuestion == DialogResult.Yes)
            {
                User user = new User();
                user.Name = addUserNameTxt.Text;
                user.Surname = addUserSurnameTxt.Text;
                user.Email = addUserEmailTxt.Text;
                user.Password = addUserPasswordTxt.Text;
                user.RoleId = Convert.ToInt32(addUserRoleCb.SelectedValue);
                user.Description = addUserDescTxt.Text;
                user.IsStatus = addUserStatusCb.Checked;


                string ımagePath = @"C:\Users\ADEMKARAGÜLLE\Desktop\MarketYönetimSistemi\images\";
                string userImage = "";
                string defaultImage = "emptyRole.jpg";

                if (UserImg.Image != null)
                {
                    string ImageName = Guid.NewGuid() + ".jpg";
                    UserImg.Image.Save(ımagePath + ImageName, ImageFormat.Jpeg);
                    userImage = ımagePath + ImageName;
                }
                else
                {
                    userImage = ımagePath + defaultImage;
                }
                user.Image = userImage;

                MessageBox.Show(userCrud.Add(user) ?
                                "Kayıt başarılı." :
                                "Kayıt başarısız.");
                addUserNameTxt.Clear();
                addUserSurnameTxt.Clear();
                addUserEmailTxt.Clear();
                addUserPasswordTxt.Clear();
                addUserDescTxt.Clear();
                addUserStatusCb.Checked = false;
                UserImg.Image = null;
            }
            else
            {
                MessageBox.Show("ekleme işlemi iptal edildi");

            }
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {
            functions.getRoleListToCb(addUserRoleCb);
        }


    }
}

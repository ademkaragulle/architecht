using MarketYönetimSistemi.Controller;
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
    public partial class Form1 : Form
    {
        UserCrud userCrud = new UserCrud();
        public static int currentUser = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void UserSignUpBtn_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            addUserForm.ShowDialog();
        }

        private void UserLoginBtn_Click(object sender, EventArgs e)
        {
            string email = LoginUserEmailTxt.Text;
            string password = LoginUserPasswordTxt.Text;
            var user = userCrud.GetAll().Where(x => x.Email == email && x.Password == password && x.RoleId == 4).FirstOrDefault();


            if (user != null)
            {
                currentUser = user.Id;
                UserPanelForm userPanelForm = new UserPanelForm();
                userPanelForm.ShowDialog();
                LoginUserEmailTxt.Clear();
                LoginUserPasswordTxt.Clear();
            }
            else
            {
                MessageBox.Show("Girdiğiniz Bilgiler hatalı");
                LoginUserEmailTxt.Clear();
                LoginUserPasswordTxt.Clear();
            }

        }

        private void AdminLoginBtn_Click(object sender, EventArgs e)
        {
            string email = LoginAdminEmailTxt.Text;
            string password = LoginAdminPasswordTxt.Text;
            var admin = userCrud.GetAll().Where(x => x.Email == email && x.Password == password && x.RoleId == 1).FirstOrDefault();


            if (admin != null)
            {
                AdminPanelForm adminPanelForm = new AdminPanelForm();
                adminPanelForm.ShowDialog();
                LoginAdminEmailTxt.Clear();
                LoginAdminPasswordTxt.Clear();
            }
            else
            {
                MessageBox.Show("Girdiğiniz Bilgiler hatalı");
                LoginAdminEmailTxt.Clear();
                LoginAdminPasswordTxt.Clear();
            }
        }
    }
}

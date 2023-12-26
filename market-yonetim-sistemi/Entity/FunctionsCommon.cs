using MarketYönetimSistemi.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketYönetimSistemi.Entity
{
    public class FunctionsCommon
    {
        RoleCrud RoleCrud = new RoleCrud();
        CategoryCrud CategoryCrud = new CategoryCrud();
        public void UploadPictureBoxImage(PictureBox picture)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Files|*.jpg;*.png;*.jpeg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picture.ImageLocation = ofd.FileName;
            }
        }

        public void getRoleListToCb(ComboBox UserRoleCb)
        {
            UserRoleCb.DataSource = RoleCrud.GetAll();
            UserRoleCb.DisplayMember = "Name";
            UserRoleCb.ValueMember = "Id";
        }

        public void getCategoryToCb(ComboBox CategoryCb)
        {
            CategoryCb.DataSource = CategoryCrud.GetAll();
            CategoryCb.DisplayMember = "Name";
            CategoryCb.ValueMember = "Id";
        }
    }
}

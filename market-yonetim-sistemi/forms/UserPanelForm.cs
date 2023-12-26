using MarketYönetimSistemi.Controller;
using MarketYönetimSistemi.Entity.Interface;
using MarketYönetimSistemi.forms;
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
    public partial class UserPanelForm : Form
    {
        public static int ProductId = 0;

        PictureBox ProductImgPB;
        Button ProductBasketBtn;
        Label ProductPriceLbl;
        GroupBox ProductGb;

        ProductCrud productCrud = new ProductCrud();
        public UserPanelForm()
        {
            InitializeComponent();
        }

        private void UserPanelForm_Load(object sender, EventArgs e)
        {
            int formWidth = (panel1.Width / 2) - (UserListTitleLbl.Width / 2);
            int formHeight = (panel1.Height / 2) - (UserListTitleLbl.Height / 2);
            UserListTitleLbl.Location = new Point(formWidth, formHeight);
        }

        private void UserPanelForm_SizeChanged(object sender, EventArgs e)
        {
            int formWidth = (panel1.Width / 2) - (UserListTitleLbl.Width / 2);
            int formHeight = (panel1.Height / 2) - (UserListTitleLbl.Height / 2);
            UserListTitleLbl.Location = new Point(formWidth, formHeight);
            panel2.Controls.Clear();
            UserListingIntoPanel();
        }


        public void UserListingIntoPanel()
        {
            int xStart = 20;
            int yStart = 20;
            int i = 0;
            int step = 170;
            int PanelWidth = panel2.Width - xStart;
            int UserGbCount = (PanelWidth - ((PanelWidth) % step)) / step;
            foreach (var product in productCrud.GetAll())
            {
                if (i == UserGbCount)
                {
                    yStart += step + 90;
                    i = 0;
                }
                ProductGb = new GroupBox()
                {
                    Name = "UserGb_" + product.Id,
                    Text = productCrud.GetById(product.Id).Name.ToString(),
                    Size = new Size(150, 240),
                    BackColor = Color.White,
                    Location = new Point(xStart + (step * i), yStart),

                };
                ProductImgPB = new PictureBox()
                {
                    Name = "UserImgPB_" + product.Id,
                    ImageLocation = product.Image,
                    Size = new Size(120, 120),
                    Location = new Point(15, 25),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                ProductPriceLbl = new Label()
                {
                    Name = "UserFullName_" + product.Id,
                    Text = "Price: " + product.Price.ToString(),
                    Location = new Point(15, 155),
                };
                ProductBasketBtn = new Button()
                {
                    Name = "UserDetailBtn_" + product.Id,
                    Text = "Add",
                    Location = new Point(15, 185),
                    Size = new Size(120, 40),
                    FlatStyle = FlatStyle.Popup,
                    BackColor = Color.Green,
                    ForeColor = Color.White,
                    Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)))
                };
                ProductBasketBtn.Click += ProductBasketBtn_Click;

                ProductGb.Controls.Add(ProductBasketBtn);
                ProductGb.Controls.Add(ProductPriceLbl);
                ProductGb.Controls.Add(ProductImgPB);

                panel2.Controls.Add(ProductGb);
                i++;
            }
        }

        private void ProductBasketBtn_Click(object sender, EventArgs e)
        {
            Button btn = ((Button)sender);
            string btnName = btn.Name;
            string[] btnId = btnName.Split('_');

            ProductId = Convert.ToInt32(btnId[btnId.Length - 1]);
            addToCartForm addToCartForm = new addToCartForm();
            addToCartForm.ShowDialog();
        }

        private void UserCartBtn_Click(object sender, EventArgs e)
        {
            CartForm CartForm = new CartForm();
            CartForm.ShowDialog();
        }

        private void UserOrderBtn_Click(object sender, EventArgs e)
        {
            Siparişlerim siparişlerim = new Siparişlerim();
            siparişlerim.ShowDialog();
        }
    }
}

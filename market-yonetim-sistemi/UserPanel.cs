using MarketYönetimSistemi.Controller;
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
using MarketYönetimSistemi.Entity;
using MarketYönetimSistemi.UserForms;
namespace MarketYönetimSistemi
{
    public partial class UserPanel : Form
    {
        ProductCrud productCrud = new ProductCrud();
        CategoryCrud categoryCrud = new CategoryCrud();
        UserCrud userCrud = new UserCrud(); 
        public static int ProdID = 0;
        

        PictureBox pb;
        Button btn;
        Label lbl;
        GroupBox group;
        public UserPanel()
        {
            InitializeComponent();
        }

        private void UserPanel_Load(object sender, EventArgs e)
        {
            LoadForm();

        }

        public void LoadForm()
        {
            int xStart = 20;
            int YStart = 20;
            int i = 0;
            int step = 170;
            int PanelWidth = ProductPnl.Width;
            int groupCount = (PanelWidth - xStart - ((PanelWidth - xStart) / step)) / step;
            foreach (var item in productCrud.GetAll())
            {

                if (i == groupCount)
                {
                    YStart += step + 90;
                    i = 0;
                }
                group = new GroupBox()
                {
                    Name = "ProductGB_" + item.Id,
                    Text = categoryCrud.GetById(item.CategoryId).Name,
                    Size = new Size(150, 240),
                    BackColor = Color.Bisque,
                    Location = new Point(step * i + xStart, YStart)

                };

                pb = new PictureBox()
                {
                    Name = "ProductImg_" + item.Id,
                    ImageLocation = item.Image,
                    Size = new Size(120, 120),
                    Location = new Point(15, 25),
                    SizeMode = PictureBoxSizeMode.StretchImage,

                };
                lbl = new Label()
                {
                    Name = "ProductLbl_" + item.Id,
                    Text = item.Name.ToString(),
                    Location = new Point(15, 155),

                };
                btn = new Button()
                {
                    Name = "AddBasketBtn_" + item.Id,
                    Text = "Sepete Ekle",
                    Location = new Point(15, 185),
                    Size = new Size(120, 40),
                    FlatStyle = FlatStyle.Popup,
                    BackColor = Color.Green,
                    ForeColor = Color.White,
                    Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))),



                };

                btn.Click += Btn_Click;
                group.Controls.Add(lbl); group.Controls.Add(pb);
                group.Controls.Add(btn);
                ProductPnl.Controls.Add(group);
                i++;

            }

            WelcomeLbl.Text += " "+ userCrud.GetById(Form1.UserId).Name;
        }

        public void ExitBtn_Click(object sender, EventArgs e)
        {
            DialogResult AddQuestion = MessageBox.Show("Çıkış Yapmak İstiyor musunuz?", "Çıkış Yap", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (AddQuestion == DialogResult.Yes) { 
                this.Close();
            }
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            string name = ((Button)sender).Name.ToString();
            string[] ProductIdArray = name.Split('_');
            int id = Convert.ToInt32(ProductIdArray[ProductIdArray.Length-1]);
            ProdID = id;
            ProductDetail pd = new ProductDetail();
            pd.ShowDialog();

        }

        private void BasketBtn_Click(object sender, EventArgs e)
        {
            Basket basket = new Basket();
            basket.ShowDialog();    

        }
    }

}

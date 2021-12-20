using BusinessLayer;
using DataAccessLayerShop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayerShop
{
    public partial class ShopApp : Form
    {

        private readonly BusinessProduct productBuisness;
        public ShopApp()
        {
            this.productBuisness = new BusinessProduct();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ShopApp_Load(object sender, EventArgs e)
        {
            RefreshData();
        }
        private void RefreshData()
        {
            List<Product> product = this.productBuisness.GetAllProducts();
            listBoxProducts.Items.Clear();
            foreach (Product p in product)
            {
                listBoxProducts.Items.Add(p.Id + " "+ p.Name +" (" + p.Description + ") - " + p.ExpireDate);
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.Name = tb_name.Text;
            p.Description = tb_description.Text;
            p.ExpireDate = dtp_expireDate.Value;
            //p.ExpireDate = Convert.ToDateTime(tb_expireDate.Text);

            this.productBuisness.InsertProduct(p);
            RefreshData();
            tb_name.Text = "";
            tb_description.Text = "";
            dtp_expireDate.Value = DateTime.Now;
        }
    }
}

using System;
using WorldyachtsBl.Model;
using System.Windows.Forms;

namespace WorldyachtsUI
{
    public partial class ProductForm : Form
    {
        public ProductForm Product { get; set; }

        public ProductForm()
        {
            InitializeComponent();
        }

        public ProductForm(ProductForm1 product) : this()
        {
            Product = product ?? new ProductForm1();
            nameProductTxtBx.Text = Product.Name;
            numericUpDownCost.Value = Product.Price;
            numericUpDownQuantity.Value = Product.Count;
        }

        void OKBtn_Click(object sender, EventArgs e)
        {
            Product = Product ?? new ProductForm1();
            Product.Name = nameProductTxtBx.Text;
            Product.Price = numericUpDownCost.Value;
            Product.Count = Convert.ToInt32(numericUpDownQuantity.Value);

            Close();
        }
    }
}

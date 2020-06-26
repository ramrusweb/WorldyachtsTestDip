using System;
using WorldyachtsBl.Model;
using System.Windows.Forms;

namespace WorldyachtsUI
{
    public partial class SellerForm : Form
    {
        public Seller Seller { get; set; }

        public SellerForm()
        {
            InitializeComponent();
        }

        public SellerForm(Seller seller) : this()
        {
            Seller = seller ?? new Seller();
            sellerNameTxtBx.Text = Seller.Name;
        }

        void sellAddBtn_Click(object sender, EventArgs e)
        {
            Seller = Seller ?? new Seller();
            Seller.Name = sellerNameTxtBx.Text;

            Close();
        }
    }
}

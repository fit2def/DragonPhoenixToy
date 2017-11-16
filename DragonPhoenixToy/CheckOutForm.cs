using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DragonPhoenixToy
{
    public partial class CheckOutForm : Form
    {
        List<Product> allProducts;

        public CheckOutForm()
        {
            InitializeComponent();
        }

        private void AddToOrderButton_Click(object sender, EventArgs e)
        {

        }

        private void ReadyToPayButton_Click(object sender, EventArgs e)
        {

        }

        private void PrintReceiptButton_Click(object sender, EventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {

        }

        private void CheckOutForm_Load(object sender, EventArgs e)
        {
            allProducts = ProductReader.Products();
        }
    }
}

using System;
using System.Windows.Forms;

namespace DragonPhoenixToy
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            ProductEntryForm entryForm = new ProductEntryForm();
            entryForm.ShowDialog();
        }

        private void CheckOutButton_Click(object sender, EventArgs e)
        {
            CheckOutForm checkoutForm = new CheckOutForm();
            checkoutForm.ShowDialog();
        }

        private void UpdateInventoryButton_Click(object sender, EventArgs e)
        {
            UpdateProductForm updateForm = new UpdateProductForm();
            updateForm.ShowDialog();
        }

        private void DisplayInventoryButton_Click(object sender, EventArgs e)
        {
            DisplayProductForm displayForm = new DisplayProductForm();
            displayForm.ShowDialog();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

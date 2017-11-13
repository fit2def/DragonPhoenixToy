using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DragonPhoenixToy
{
    public partial class ProductEntryForm : Form
    {
        private List<Product> allProducts;
        public ProductEntryForm()
        {
            allProducts = ProductRepository.GetProducts();
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                Product p = GetProductFromForm();
                if (ProductIsValid(p))
                    StoreProduct(p);
            }
            catch
            {
                MessageBox.Show("Price and onhand should be a number.");
            }
        }

        private Product GetProductFromForm()
        {
            return new Product
            {
                ID = productIdInput.Text,
                Description = descriptionInput.Text,
                Name = productNameInput.Text,
                Price = double.Parse(productPriceInput.Text),
                OnHand = int.Parse(productOnHandInput.Text)
            };
        }


        private bool ProductIsValid(Product p)
        {
            return ProductDoesntExist(p) && NoStringsAreEmpty(p);
        }

        private bool ProductDoesntExist(Product p)
        {
            foreach (Product product in allProducts)
            {
                if (product.ID == p.ID)
                {
                    MessageBox.Show("Product already exists.");
                    return false;
                }

            }
            return true;
        }

        private bool NoStringsAreEmpty(Product p)
        {
            bool filled =
                !string.IsNullOrEmpty(p.ID) &
                !string.IsNullOrEmpty(p.Name) &
                !string.IsNullOrEmpty(p.Description);
            if (!filled)
                MessageBox.Show("You must fill all fields");
            return filled;

        }



        private void StoreProduct(Product p)
        {

        }

        private void ProductEntryForm_Load(object sender, EventArgs e)
        {

        }
    }
}

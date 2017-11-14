using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DragonPhoenixToy
{
    public partial class ProductEntryForm : Form
    {
        private List<Product> allProducts;
        private bool ValidNumericInputs;

        public ProductEntryForm()
        {
            allProducts = ProductRepository.GetProducts();
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            ResetValidation();

            Product p = GetProductFromForm();
            if (FormIsValid(p))
                StoreProduct(p);
        }

        private void ResetValidation()
        {
            ValidNumericInputs = true;
        }

        private Product GetProductFromForm() =>
           new Product
           {
               ID = productIdInput.Text,
               Description = descriptionInput.Text,
               Name = productNameInput.Text,
               Price = GetPrice(),
               OnHand = GetOnHand()
           };

        private double GetPrice()
        {
            double price = 0;
            try
            {
                price = double.Parse(productPriceInput.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("The price must be a valid decimal number.");
                productPriceInput.Focus();
                ValidNumericInputs = false;
            }
            return price;
        }

        private int GetOnHand()
        {
            int onHand = 0;
            try
            {
                onHand = int.Parse(productOnHandInput.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Must enter a valid number of product on hand.");
                productOnHandInput.Focus();
                ValidNumericInputs = false;
            }
            return onHand;
        }

        private bool FormIsValid(Product p)
        {
            return ValidNumericInputs && ProductDoesntExist(p) && NoStringsAreEmpty(p);
        }

        private bool ProductDoesntExist(Product p)
        {
            foreach (Product product in allProducts)
            {
                if (product.ID == p.ID)
                {
                    MessageBox.Show("Product already exists.");
                    productIdInput.Focus();
                    return false;
                }
            }
            return true;
        }

        private bool NoStringsAreEmpty(Product p) =>
            IdFilled(p.ID) &
            NameFilled(p.Name) &
            DescriptionFilled(p.Description);

        private bool IdFilled(string id)
        {
            bool filled = !string.IsNullOrEmpty(id);
            if (!filled)
                MessageBox.Show("Must provide product ID");
            productIdInput.Focus();
            return filled;
        }

        private bool NameFilled(string name)
        {
            bool filled = !string.IsNullOrEmpty(name);
            if (!filled)
                MessageBox.Show("Must provide name");
            productNameInput.Focus();
            return filled;
        }

        private bool DescriptionFilled(string description)
        {
            bool filled = !string.IsNullOrEmpty(description);
            if (!filled)
                MessageBox.Show("Must provide product description");
            descriptionInput.Focus();
            return filled;
        }

        private void StoreProduct(Product p)
        {
            //Todo serialize product
        }

        private void ProductEntryForm_Load(object sender, EventArgs e)
        {
            //Todo deserialize and store in allProducts
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DragonPhoenixToy
{
    public partial class UpdateProductForm : Form
    {
        List<Product> allProducts = new List<Product>();

        public UpdateProductForm()
        {
            InitializeComponent();
        }

        private void UpdateProductForm_Load(object sender, EventArgs e)
        {
            allProducts = ProductReader.Products();
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            Product p = allProducts.FirstOrDefault(x => x.ID == ProductIdTextBox.Text);
            if (p == null)
                NoProductFound();
            else
                FillInputsWithFoundProduct(p);
        }

        private void FillInputsWithFoundProduct(Product p)
        {
            ProductIdTextBox.Text = p.ID;
            ProductIdTextBox.ReadOnly = true;
            ProductNameTextBox.Text = p.Name;
            DescriptionTextBox.Text = p.Description;
            ProductPriceTextBox.Text = p.Price.ToString();
            onHandCount.Text = p.OnHand.ToString();
        }

        private void NoProductFound()
        {
            MessageBox.Show("No product with that ID found.");
            ProductIdTextBox.Focus();
            ProductIdTextBox.SelectAll(); 
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (InputsAreValid())
            {
                int index = GetIndexOfCurrentProduct();
                if (index >= 0)
                {
                    UpdateProductAtIndex(index);
                    CleanUpForm();
                }
                else
                    NoProductFound();
            }
        }

        private bool InputsAreValid() =>
            NameIsFilled() && DescriptionIsFilled()
                && PriceIsValid() && AdditionalQuantityIsValid();

        private bool NameIsFilled()
        {
            bool filled = !(string.IsNullOrEmpty(ProductNameTextBox.Text));
            if (!filled)
            {
                MessageBox.Show("Product name cannot be empty");
                ProductNameTextBox.Focus();
            }
            return filled;
        }

        private bool DescriptionIsFilled()
        {
            bool filled = !string.IsNullOrEmpty(DescriptionTextBox.Text);
            if (!filled)
            {
                MessageBox.Show("Description cannot be empty");
                DescriptionTextBox.Focus();
            }
            return filled;
        }

        private bool PriceIsValid()
        {
            try
            {
                double.Parse(ProductPriceTextBox.Text);
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Price must be a valid decimal number.");
                ProductPriceTextBox.Focus();
                return false;
            }
        }

        private bool AdditionalQuantityIsValid()
        {
            try
            {
                int.Parse(NewProductArrivedTextBox.Text);
                return true;
            }
            catch (Exception)
            {
                if (NewProductArrivedTextBox.Text.Length == 0)
                    return true;
                else
                {
                    MessageBox.Show("Arrival quantity must be a valid number.");
                    NewProductArrivedTextBox.Focus();
                    return false;
                }
            }
        }

        private int GetIndexOfCurrentProduct() =>
            allProducts.FindIndex(p => p.ID == ProductIdTextBox.Text);
            
        private void UpdateProductAtIndex(int index)
        {
            allProducts[index].Name = ProductNameTextBox.Text;
            allProducts[index].Description = DescriptionTextBox.Text;
            allProducts[index].Price = Double.Parse(ProductPriceTextBox.Text);
            int onHand = 0;
            bool onHandEntered = int.TryParse(NewProductArrivedTextBox.Text, out onHand);
            allProducts[index].OnHand += onHand;
        }

        private void CleanUpForm()
        {
            MessageBox.Show("Product updated.");
            ProductIdTextBox.ReadOnly = false;
            ClearButton.PerformClick();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Clear();
            ProductIdTextBox.ReadOnly = false;
            ProductIdTextBox.Focus();
        }

        private void Clear()
        {
            ProductIdTextBox.Clear();
            ProductNameTextBox.Clear();
            DescriptionTextBox.Clear();
            ProductPriceTextBox.Clear();
            NewProductArrivedTextBox.Clear();
            onHandCount.Clear();
        }

        private void SaveAndCloseButton_Click(object sender, EventArgs e)
        {
            foreach (Product p in allProducts)
                ProductWriter.AddProduct(p);
            Close();
        }

    }
}

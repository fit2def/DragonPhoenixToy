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
            Product p = GetProductFromForm();
            if (ProductIsValid(p))
                StoreProduct(p);
        }

        private Product GetProductFromForm()
        {
            throw new NotImplementedException();
        }

        private bool ProductDoesntExist(Product p)
        {
            throw new NotImplementedException();
        }

        private bool ProductIsValid(Product p)
        {
            return ProductDoesntExist(p) && ProductIdIsntBlank(p);
        }

        private bool ProductIdIsntBlank(Product p)
        {
            throw new NotImplementedException();
        }

        private void StoreProduct(Product p)
        {

        }
    }
}

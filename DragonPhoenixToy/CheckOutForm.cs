﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DragonPhoenixToy
{
    public partial class CheckOutForm : Form
    {
        List<Product> allProducts;
        List<Product> productsInOrder = new List<Product>();
        Order order;

        public CheckOutForm()
        {
            InitializeComponent();
        }

        private void AddToOrderButton_Click(object sender, EventArgs e)
        {
            if (InputsAreValid())
            {
                AddToOrder();
                CleanUp();
            }
        }

        private bool InputsAreValid()
        {
            return IdIsValid() && UnitSoldIsValid();
        }

        private bool IdIsValid()
        {
            string text = idTextBox.Text;
            Product product = allProducts.Find(p => p.ID == text);
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Please enter a product ID");
                return false;
            }
            else if (product == null)
            {
                MessageBox.Show("Product doesn't exist");
                return false;
            }
            return true;

        }

        private bool UnitSoldIsValid()
        {
            try
            {
                var units = int.Parse(unitsSoldTextBox.Text);
                Product product = allProducts.Find(p => p.ID == idTextBox.Text);
                if (!(product.OnHand >= units))
                {
                    MessageBox.Show($"Not enough in stock. Only have {product.OnHand} left.");
                    unitsSoldTextBox.Focus();
                    return false;
                }

                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Units sold must be a whole number.");
                unitsSoldTextBox.Focus();
                unitsSoldTextBox.SelectAll();
                return false;
            }
        }

        private void AddToOrder()
        {
            int index = allProducts.FindIndex(p => p.ID == idTextBox.Text);
            Product product = allProducts[index];
            int units = int.Parse(unitsSoldTextBox.Text);
            product.UnitSold = units;
            product.OnHand -= units;
            productsInOrder.Add(product);
            ProductWriter.AddProduct(product);
        }

        private void CleanUp()
        {
            idTextBox.Clear();
            unitsSoldTextBox.Clear();
            unitsSoldTextBox.Focus();
        }

        private void ReadyToPayButton_Click(object sender, EventArgs e)
        {
            ReceiptListBox.Items.Clear();
            order = new Order { Items = productsInOrder };
            ReceiptListBox.Items.AddRange(order.ToString().Split('\n'));
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CheckOutForm_Load(object sender, EventArgs e) =>
            allProducts = ProductReader.Products();

        private void PrintReceiptButton_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (order == null)
                MessageBox.Show("Sorry, cannot print receipt without the order being paid");
            else
            {
                e.Graphics.DrawString(order.ToString(),
                    new Font("Courier", 12, FontStyle.Regular),
                    Brushes.Black, 50, 100);
            }
        }
    }
}

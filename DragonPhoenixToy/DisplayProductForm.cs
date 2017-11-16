using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragonPhoenixToy
{
    public partial class DisplayProductForm : Form
    {
        private List<Product> allProducts;
        public DisplayProductForm()
        {
            InitializeComponent();
        }

        private void DisplayProductForm_Load(object sender, EventArgs e)
        {
            allProducts = ProductReader.Products();
            foreach (var p in allProducts)
                DisplayListBox.Items.Add(p);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int x = 100, y = 100;
            foreach (Product p in allProducts)
            {
                e.Graphics.DrawString(p.ToString(),
                    new Font("Courier New", 12, FontStyle.Regular),
                    Brushes.Black, x, y);
                y += 15;
            }
        }
    }
}

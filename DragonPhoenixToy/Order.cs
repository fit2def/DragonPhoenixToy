using System;
using System.Collections.Generic;
using System.Text;

namespace DragonPhoenixToy
{
    public class Order
    {
        public const double TaxRate = 0.09;
        public List<Product> Items { get; set; }

        public double CalculateSubTotal()
        {
            double subTotal = 0.0;
            foreach (Product p in Items)
            {
                subTotal += p.CalculateProductCost();
            }
            return subTotal;
        }

        public double CalculateTax()
        {
            double taxAmount = 0.0;
            taxAmount = CalculateSubTotal() * TaxRate;
            return taxAmount;
        }

        public double CalculateTotal()
        {
            double total = 0.0;
            total = CalculateSubTotal() + CalculateTax();
            return total;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("Dragon Phoenix Toy");
            builder.AppendLine("123 Toy St.");
            builder.AppendLine("Argentina OK 48451");
            builder.AppendLine($"{DateTime.Now}");
            foreach (Product p in Items)
            {
                builder.AppendLine($"{p.Name:-15} {p.UnitSold:5} {p.CalculateProductCost():5:n2}");
                builder.AppendLine($"{"Sub total:":-20}{CalculateSubTotal():-10:n2}");
                builder.AppendLine($"{"Tax:":-20}{CalculateTax():-10:n2}");
                builder.AppendLine($"{"Total":-20}{CalculateTotal():-10:n2}");

            }
            return builder.ToString();
        }
    }
}

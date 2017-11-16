using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace DragonPhoenixToy
{
    public static class ProductReader
    {
        public static List<Product> Products()
        {
            List<Product> products = new List<Product>();
            IEnumerable<string> productIds = GetProductIds();

            foreach (var id in productIds)
            {
                Product p = ReadSingleProduct(id);
                products.Add(p);
            }
            return products;
                
        }

        private static IEnumerable<string> GetProductIds()
        {
            List<string> fileNames = new List<string>();
            var files = Directory.GetFiles("Products");
            foreach (var f in files)
            {
                fileNames.Add(f);
            }
            return fileNames;

        }

        private static Product ReadSingleProduct(string fileName)
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(Product));

            Product p; 
            using (StreamReader sr = new StreamReader(fileName))
            {
                p = (Product)xmlFormat.Deserialize(sr);
            }
            return p;
        }
    }
}

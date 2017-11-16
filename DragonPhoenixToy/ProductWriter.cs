using System.IO;
using System.Xml.Serialization;

namespace DragonPhoenixToy
{
    public static class ProductWriter
    {
        public static void AddProduct(Product p)
        {
            XmlSerializer xmlFormatter = new XmlSerializer(typeof(Product));
            using (Stream fStream = new FileStream($"Products/{p.ID}.xml",
                FileMode.Create, FileAccess.Write, FileShare.None))
            {
                xmlFormatter.Serialize(fStream, p);
            }
        }
    }
}

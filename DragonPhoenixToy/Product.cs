using System;

namespace DragonPhoenixToy
{
    [Serializable]
    public class Product
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int OnHand { get; set; }
        public int UnitSold { get; set; }

        public double CalculateProductCost() =>
            Price * UnitSold;

        public override string ToString()
        {
            return $"{ID} {Name} {Description} {Price} {OnHand}";
        }



    }
}

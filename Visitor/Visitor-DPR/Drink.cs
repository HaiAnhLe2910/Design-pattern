using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_DPR
{
    public class Drink : IProductElement
    {
        //properties
        public double Price { get; set; }
        public string Brand { get; set; }

        //Constructor
        public Drink()
        {
        }

        //Methods
        public double Accept(IShoppingCartVisitor visitor)
        {
            return visitor.Visit(this);
        }

        public override string ToString()
        {
            return "price: " + Price + " " + "Brand: " + Brand;
        }
        //public double GetPrice() => Price;
        //public string GetBrand() => Brand;

    }
}

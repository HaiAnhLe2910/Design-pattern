using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_DPR
{
    public abstract class Fruits : IProductElement
    {
        //properties
        public double Price { get; set; }
        public string Origin { get; set; }
        public bool Bio { get; set; }

        //Constructor

        public Fruits()
        {

        }

        //Methods
        public double Accept(IShoppingCartVisitor visitor)
        {
            return visitor.Visit(this);
        }

        public override string ToString()
        {
            return "price: " + Price + " " + "Orgin: " + Origin + " " + "Bio: " + Bio.ToString();
        }
        //public double GetPrice() => Price;
        //public string GetOrigin() => Origin;

        //public bool IsBio() => Bio;

    }
}

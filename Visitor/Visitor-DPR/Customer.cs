using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_DPR
{
    public class Customer
    {
        //Properties
        public IShoppingCartVisitor visitor { get; set; }
        
        //Constructor
        public Customer(IShoppingCartVisitor visitor)
        {
            this.visitor = visitor;
        }

        //Methods
        public double CalculateCost(List<IProductElement> products)
        {
            double totalPrice = 0;
            foreach(IProductElement product in products)
            {
                totalPrice += product.Accept(visitor);
            }
            return totalPrice;
        }
    }
}

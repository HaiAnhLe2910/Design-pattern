using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_DPR
{
    public class NormalMembershipVisitor : IShoppingCartVisitor
    {
        public double Visit(Fruits vegetables) => vegetables.Price;
        public double Visit(Drink drink) =>drink.Price;
    }
}

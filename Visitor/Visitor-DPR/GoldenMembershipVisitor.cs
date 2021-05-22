using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_DPR
{
    class GoldenMembershipVisitor : IShoppingCartVisitor
    {
        public double Visit(Fruits vegetables) => 0.7*vegetables.Price;
        public double Visit(Drink drink) =>0.8* drink.Price;
    }
}

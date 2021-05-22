using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_DPR
{
    public interface IShoppingCartVisitor
    {
        double Visit(Fruits vegetables);
        double Visit(Drink drink);
    }
}

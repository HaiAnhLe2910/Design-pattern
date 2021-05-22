using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3
{
    class Milk : CondimentDecorator
    {
        //Constructor
        public Milk(IBeverage beverage):base(beverage)
        { }

        //methods
        public override decimal GetCost() => beverage.GetCost() + 0.5m;

        public override string GetDescription()
        {
            return beverage.GetDescription() + "+ Milk";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3
{
    class Whip : CondimentDecorator
    {
        //Constructor
        public Whip(IBeverage beverage) : base(beverage)
        { }

        //methods
        public override decimal GetCost() => beverage.GetCost() + 2.5m;

        public override string GetDescription()
        {
            return beverage.GetDescription() + " + Whip";
        }
    }
}

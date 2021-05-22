using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3
{
    abstract class CondimentDecorator : IBeverage
    {
        //field
        protected IBeverage beverage;

        //Constructor
        protected CondimentDecorator(IBeverage beverage)
        {
            this.beverage = beverage;
        }

        //Method
        public abstract decimal GetCost();

        public abstract string GetDescription();
      
    }
}

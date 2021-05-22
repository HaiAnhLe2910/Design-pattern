using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3
{
    class Mocha : CondimentDecorator
    {
       // int counter = 0;
        //Constructor
        public Mocha(IBeverage beverage) : base(beverage)
        { }

        //methods
        public override decimal GetCost() => beverage.GetCost() + 1.5m;

        public override string GetDescription()
        {

            //if (counter == 0)
            //{
            //    counter++;
            //    return beverage.GetDescription() + " + Mocha";

            //}
            //else
            //{
                return beverage.GetDescription();
           // }

        }


       


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3
{
    class HouseBlend : IBeverage
    {
        public decimal GetCost() => 1.99M;

        public string GetDescription()
        {
            return "HouseBlend ";
        }
    }
}

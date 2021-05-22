using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3
{
    class Expresso : IBeverage
    {
        public decimal GetCost() => 3.99M;

        public string GetDescription()
        {
            return "Expresso ";
        }
    }
}

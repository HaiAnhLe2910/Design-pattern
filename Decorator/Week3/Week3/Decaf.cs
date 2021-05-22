using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3
{
    class Decaf : IBeverage
    {
        public decimal GetCost() => 2.99M;

        public string GetDescription()
        {
            return "Decaf ";
        }
    }
}

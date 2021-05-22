using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_DPR
{
    public class Coffee:Drink
    {
        public Coffee() : base()
        {
            Price = 3;
            Brand = "Starbucks";

        }

        public override string ToString()
        {
            return "Coffee" + " " + base.ToString();
        }
    }
}

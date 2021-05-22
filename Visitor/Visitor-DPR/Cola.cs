using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_DPR
{
    public class Cola : Drink
    {
        public Cola() : base()
        {
            Price = 2;
            Brand = "CocaCola";
        }

        public override string ToString()
        {
            return "Cola" + " " + base.ToString();
        }


    }
}

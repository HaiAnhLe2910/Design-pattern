using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_DPR
{
    public class Apple : Fruits
    {
        public Apple() : base()
        {
            Price = 1;
            Origin = "Vietnam";
            Bio = true;
        }

        public override string ToString()
        {
            return "Apple" + " " + base.ToString();
        }

    }
}

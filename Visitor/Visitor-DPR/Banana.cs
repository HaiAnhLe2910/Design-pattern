using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_DPR
{
    public class Banana:Fruits
    {
        public Banana() : base()
        {
            this.Price = 1.5;
            this.Origin = "Syria";
            this.Bio = false;
        }

        public override string ToString()
        {
            return "Banana" + " " + base.ToString();
        }
    }
}

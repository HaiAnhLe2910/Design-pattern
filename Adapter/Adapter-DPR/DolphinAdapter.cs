using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_DPR
{
    class DolphinAdapter:IDuck 
    {
        //fields
        private Dolphin dolphin;

        //Constructor
        public DolphinAdapter(Dolphin dolphin)
        {
            this.dolphin = dolphin;
        }

        //Methods
        public string Squeak() => dolphin.Bubble();
        public string Fly() => dolphin.Swim();

    }
}

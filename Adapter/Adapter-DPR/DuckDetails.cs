using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_DPR
{
    class DuckDetails
    {
        //fields
        private IDuck duck;

        //Constructor
        public DuckDetails(IDuck duck)
        {
            this.duck = duck;
        }

        //Methods
        public string GetSqueakSound()=> duck.Squeak();
        public string GetFlyMethod() => duck.Fly();
    }
}

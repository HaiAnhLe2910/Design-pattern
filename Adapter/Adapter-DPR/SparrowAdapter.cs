using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_DPR
{
    class SparrowAdapter : IDuck
    {
        //fields
        private Sparrow sparrow;

        //Constructor
        public SparrowAdapter(Sparrow sparrow)
        {
            this.sparrow = sparrow;
        }

        //Methods
        public string Squeak()=> sparrow.MakeSound();
        public string Fly()=> sparrow.Fly();       


    }
}

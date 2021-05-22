using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_DPR
{
    class PlasticDuck : IDuck
    {
        public string Fly()
        {
            return "I am flying in a short distance!";
        }

        public string Squeak()
        {
            return "squeaking";
        }
    }
}

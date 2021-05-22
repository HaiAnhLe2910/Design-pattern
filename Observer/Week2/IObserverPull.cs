using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
{
    public interface IObserverPull
    { 
        //This method will execute when the subject has an update.
        void UpdateData();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
{
    public interface IObserverPush
    {
        //This method will execute when the subject has an update, and get the update automatically.
        void Update(float temperature, float humidity, float pressure);
    }
}

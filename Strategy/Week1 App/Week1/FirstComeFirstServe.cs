using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1
{
    class FirstComeFirstServe : IDiskSchedule
    {
        public int ProcessRequests(List<int> requests, int head)
        {
            if (requests.Count != 0)
            {
                return requests[0];
            }
            else
            {
                return -1;
            }
        }

    }
}

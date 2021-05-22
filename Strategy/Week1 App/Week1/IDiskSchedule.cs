using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1
{
    interface IDiskSchedule
    {
        int ProcessRequests(List<int> requests, int head);
    }
}

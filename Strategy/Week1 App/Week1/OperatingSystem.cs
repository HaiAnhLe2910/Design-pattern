using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1
{
    class OperatingSystem
    {
        //fields
        protected IDiskSchedule processingBehavior;
        protected List<int> requests;

        //Constructor
        public OperatingSystem(IDiskSchedule processingBehavior, List<int> requests)
        {
            this.processingBehavior = processingBehavior;
            this.requests = requests;
        }

        //Methods
        public int PerformProcessingRequests(int head)
        {
            return processingBehavior.ProcessRequests(requests,head);
        }
    }
}

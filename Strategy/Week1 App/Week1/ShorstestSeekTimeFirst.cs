using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1
{
    class ShorstestSeekTimeFirst : IDiskSchedule
    {
        public int ProcessRequests(List<int> requests,int head)
        {

            //List<int> tempList = new List<int>(requests);
            //List<int> returnedReq = new List<int>();

            int shouldbeAddedReq = 0;
            int shorstestSeekTime = 1000000;

                foreach (int req in requests)
                {
                    if (Math.Abs(head - req) < shorstestSeekTime)
                    {
                        shorstestSeekTime = Math.Abs(head - req);
                        shouldbeAddedReq = req;
                    }
                }
            return shouldbeAddedReq;
                //tempList.Remove(shouldbeAddedReq);
                //returnedReq.Add(shouldbeAddedReq);

        }
    }
}

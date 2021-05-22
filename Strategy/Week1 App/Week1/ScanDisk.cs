using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1
{
    class ScanDisk : IDiskSchedule
    {
        public int ProcessRequests2(List<int> requests, int head)
        {
            int average = (requests.Max() - requests.Min()) / 2;
            int smallestDif = 1000000000;
            int request = 0;

            //Go Up
            if(head>average||head==average)
            {
                foreach (int item in requests)
                {
                    if (item > head)
                    {
                        if (Math.Abs(head - item) < smallestDif)
                        {
                            smallestDif = Math.Abs(head - item);
                            request = item;
                        }
                    }
                    else
                    {

                    }
                   
                }
            }
            //Go down
            else if(head<average)
            {
                foreach (int item in requests)
                {
                    if (item < head)
                    {
                        if (Math.Abs(head - item) < smallestDif)
                        {
                            smallestDif = Math.Abs(head - item);
                            request = item;
                        }
                    }
                }
            }
            return request;

        }

        public int ProcessRequests(List<int> requests, int head)
        {
            if (requests.Count > 0)
            {
                int average = (requests.Max() - requests.Min()) / 2;


                //int smallestDif = 1000000000;
                //int request = 0;

                int reqToReturn = -1;

                List<int> moreThanTheHead = new List<int>();
                List<int> LessThanTheHead = new List<int>();

                foreach (int item in requests)
                {
                    if (item > head)
                    {
                        moreThanTheHead.Add(item);
                    }
                    else if (item < head)
                    {
                        LessThanTheHead.Add(item);
                    }
                }

                moreThanTheHead.Sort();
                LessThanTheHead.Sort();

                //Go Up
                if (head >= average)
                {
                    if (moreThanTheHead.Count > 0)
                    {
                        reqToReturn = moreThanTheHead.Min();
                    }
                    else if (LessThanTheHead.Count > 0)
                    {
                        reqToReturn = LessThanTheHead.Max();
                    }
                    else
                    {
                        reqToReturn = -1;
                    }
                }
                else if (head < average)//Go Down
                {
                    if (LessThanTheHead.Count > 0)
                    {
                        reqToReturn = LessThanTheHead.Max();
                    }
                    else if (moreThanTheHead.Count > 0)
                    {
                        reqToReturn = moreThanTheHead.Min();
                    }
                    else
                    {
                        reqToReturn = -1;
                    }
                }


            return reqToReturn;
            }
            return -1;

        }
    }
}

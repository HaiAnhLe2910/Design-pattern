using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
{
    public class WeatherDataSubject 
    {
        //fields
        private List<IObserverPush> ObserversPush;
        private List<IObserverPull> ObserversPull;
        private float temperature;
        private float humidity;
        private float pressure;

        //Constructor
        public WeatherDataSubject()
        {
            ObserversPush = new List<IObserverPush>();
            ObserversPull = new List<IObserverPull>();
        }

        //Methods

        //To attach a subscriber which is using the pull way of receiving data to this subject.
        public void Attach(IObserverPull o)
        {
            //Add the subscriber to the list of the the subcribers that are using the pull way.
            ObserversPull.Add(o);
        }

        //To attach a subscriber which is using the push way of receiving data to this subject.
        public void Attach(IObserverPush o)
        {
            //Add the subscriber to the list of the the subcribers that are using the push way.
            ObserversPush.Add(o);
        }

        //To Detach a subscriber which is using the pull way of receiving data from this subject.
        public void Detach(IObserverPull o)
        {
            //Remove the subscriber to the list of the the subcribers that are using the pull way.
            ObserversPull.Remove(o);
        }

        //To Detach a subscriber which is using the push way of receiving data from this subject.
        public void Detach(IObserverPush o)
        {
            //Add the subscriber to the list of the the subcribers that are using the push way.
            ObserversPush.Remove(o);
        }

        //Notify all the subscriber's with the new Measurement data.
        protected void Notify()
        {
            //Norify all the subsciber's that are using the push way.
            foreach (IObserverPush o in ObserversPush)
                o.Update(temperature, humidity, pressure);

            //Norify all the subsciber's that are using the pull way.
            foreach (IObserverPull o in ObserversPull)
                o.UpdateData();
        }

        //Update the measured data, and notify the subscribers with the new data.
        public void SetMeasurementData(float temperature, float humidity,float pressure)
        {
            //Update the measured data.
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;

            //notify the subscribers with the new data.
            Notify();
        }

        //To get the current measured data.
        //This method is used by the subscribers that are using the pull way of receiving data.
        public float[] GetMeasurementData()
        {
            float[] measurementData = new float[3];
            measurementData[0] = temperature;
            measurementData[1] = humidity;
            measurementData[2] = pressure;
            return measurementData;
        }
    }
}

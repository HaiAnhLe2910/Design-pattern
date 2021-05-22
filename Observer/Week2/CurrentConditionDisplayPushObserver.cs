using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
{
    public class CurrentConditionDisplayPushObserver : IObserverPush
    {
        //fields
        private float temperature;
        private float humidity;
        private float pressure;
        private WeatherDataSubject dataSubject;

        //Constructor
        public CurrentConditionDisplayPushObserver(WeatherDataSubject dataSubject)
        {
            this.dataSubject = dataSubject;
            dataSubject.Attach(this);
        }
        //Methods
        public void Update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
        }
    }
}

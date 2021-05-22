using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week2
{
    public partial class PushForm : Form,IObserverPush
    {
        //Store the Subject which is going to notify this when there is an update with the data.
        private WeatherDataSubject subject;

        //Constructor
        public PushForm(WeatherDataSubject subject)
        {
            InitializeComponent();

            //Store the subject.
            this.subject = subject;

            //subscribe this object to subject.
            subject.Attach(this);
        }

        //To get and display the new data.
        //This method will execute when the subject has an update,and it will recive the data automatically.
        public void Update(float temperature, float humidity, float pressure)
        {
            lbTemp.Text = temperature.ToString();
            lbHumid.Text = humidity.ToString();
            lbPressure.Text = pressure.ToString();
        }

        private void PushForm_Load(object sender, EventArgs e)
        {

        }
    }
}

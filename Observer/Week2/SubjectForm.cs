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
    public partial class Form1 : Form
    {
        //The object of the WeatherDataSubject which represent the weather station.
        private WeatherDataSubject subject;
        public Form1()
        {
            InitializeComponent();
            subject = new WeatherDataSubject();

            //Create an object from every subscriber form.
            PushForm pushForm = new PushForm(subject);
            PullForm pullForm = new PullForm(subject);

            //show the subscriber's forms.
            pushForm.Show();
            pullForm.Show();
        }
    
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSetData_Click(object sender, EventArgs e)
        {
            //Store the measured data form the user as an float numbers.
            float temp = Convert.ToSingle(tbTemp.Text);
            float humid = Convert.ToSingle(tbHumid.Text);
            float pressure = Convert.ToSingle(tbPressure.Text);

            //Update the Measuremen data.
            subject.SetMeasurementData(temp, humid, pressure);
        }
    }
}

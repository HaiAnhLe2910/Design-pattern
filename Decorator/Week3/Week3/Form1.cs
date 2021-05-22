using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week3
{
    public partial class Form1 : Form
    {
        IBeverage myBeverage;
        private string Descrip;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            //Make myBeverage null.
            myBeverage = null;
           
            if(rbHouseBlend.Checked)
            {
                myBeverage = new HouseBlend();
            }
            else if(rbDecaf.Checked)
            {
                myBeverage = new Decaf();
            }
            else
            {
                myBeverage = new Expresso();
            }

            
            if(cbMilk.Checked)
            {
                int amountOFMilk = Convert.ToInt32(comboMilk.Text);

                for (int i = 0; i < amountOFMilk; i++)
                {
                    myBeverage = new Milk(myBeverage);
                }
               // Descrip = myBeverage.GetDescription() + " " + amountOFMilk;
            }

            if (cbMocha.Checked)
            {
                int amountOFMocha = Convert.ToInt32(comboMocha.Text);

                for (int i = 0; i < amountOFMocha; i++)
                {
                    myBeverage = new Mocha(myBeverage);
                }

               // Descrip = myBeverage.GetDescription() + " " + amountOFMocha;
            }

            if (cbSoy.Checked)
            {
                int amountOFSoy = Convert.ToInt32(comboSoy.Text);

                for (int i = 0; i < amountOFSoy; i++)
                {
                    myBeverage = new Soy(myBeverage);
                }

              //  Descrip = myBeverage.GetDescription() + " " + amountOFSoy;
            }

            if (cbWhip.Checked)
            {
                int amountOFWhip = Convert.ToInt32(comboWhip.Text);

                for (int i = 0; i < amountOFWhip; i++)
                {
                    myBeverage = new Whip(myBeverage);
                  
                }

              //  Descrip = myBeverage.GetDescription() + " "+amountOFWhip;
            }


            tbPrice.Text = myBeverage.GetCost().ToString();
           

             tbDescription.Text = "You ordered : " + myBeverage.GetDescription() + '.';
        }



        private void cbMilk_CheckedChanged(object sender, EventArgs e)
        {
            
            comboMilk.Enabled = cbMilk.Checked;
        }

        private void cbMocha_CheckedChanged(object sender, EventArgs e)
        {
            
            comboMocha.Enabled = cbMocha.Checked;
        }

        private void cbSoy_CheckedChanged(object sender, EventArgs e)
        {
            
            comboSoy.Enabled = cbSoy.Checked;
        }

        private void cbWhip_CheckedChanged(object sender, EventArgs e)
        {
            
            comboWhip.Enabled = cbWhip.Checked;
        }
    }
}

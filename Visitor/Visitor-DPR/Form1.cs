using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visitor_DPR
{
    public partial class Form1 : Form
    {
        SupermarketStructure supermarket;
        IShoppingCartVisitor customerType;
        List<IProductElement> order;

        public Form1()
        {
            InitializeComponent();

            supermarket = new SupermarketStructure();
            customerType = new NormalMembershipVisitor();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(lbOrder.SelectedItem != null)
            {
                supermarket.DeleteElement( ((IProductElement)lbOrder.SelectedItem) );
            }
            ShowOrder();

        }

        private void numericUpDownDrinks_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ////Make the ready.
            order = new List<IProductElement>();

            if(radioButtonApple.Checked)
                //For the Apples
                AddProductToOrderList(new Apple());
            else if(radioButtonBanana.Checked)
                //For the Apples
                AddProductToOrderList(new Banana());
            else if(radioButtonCoffee.Checked)
                AddProductToOrderList(new Coffee());
            else
                AddProductToOrderList(new Cola());
            

            //To Show The Orders in the listbox.
            ShowOrder();
        }

        private void AddProductToOrderList(IProductElement element)
        {
            for (int i = 0; i < numericUpDownAll.Value; i++)
            {
                //order.Add(element);
                supermarket.AddElement(element);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rbNormalCustmor_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNormalCustmor.Checked)
            {
                customerType = new NormalMembershipVisitor();
            }
        }

        private void rbGoldenCustmor_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGoldenCustmor.Checked)
            {
                customerType = new GoldenMembershipVisitor();
            }
        }

        private void ShowOrder()
        {
            lbOrder.Items.Clear();
            foreach (var item in supermarket.ProductElements)
            {
                lbOrder.Items.Add(item);
            }
        }

        private void btnShowPrice_Click(object sender, EventArgs e)
        {
            MessageBox.Show(supermarket.Accept(customerType).ToString());
        }

        private void btnNewClient_Click(object sender, EventArgs e)
        {
            supermarket.NewClient();
            rbNormalCustmor.Checked = true;
            radioButtonApple.Checked = true;
            ShowOrder();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

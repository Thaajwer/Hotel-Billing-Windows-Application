using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs_fast_food
{
    public partial class Form1 : Form
    {

        const double price_fries =2.8;
        const double price_salad = 3.7;
        const double price_humburger = 2.5;
        const double price_onionrings = 3.6;
        const double price_chickensalad = 4.4;
        const double price_fishsandwich = 4.5;
        const double price_cheesesandwich = 3.2;
        const double price_chickensandwich = 1.0;
        const double price_hashbrown = 5.0;
        const double price_toastedbagel = 9.2;
        const double price_pineapplestick = 45.0;
        const double price_choclatemuffin = 50.0;

        const double price_pancakessyrup = 30.0;
        const double price_tea = 35.0;
        const double price_cola = 15.0;

        const double price_coffee = 25.0;
        const double price_sprite = 35.0;
        const double price_pepsi = 45.0;
        const double price_vanilacone = 45.0;
        const double price_vanilashake = 25.0;
        const double price_strawberryshake = 15.0;
        const double price_choclatemilkshake = 95.0;
        const double tax_rate = 7.0;

        double itax, isubtotal, itotal;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            comboBox1.Items.Add("");
            comboBox1.Items.Add("cash");
            comboBox1.Items.Add("visa card");
            comboBox1.Items.Add("mater card");
            comboBox1.Items.Add("debit card");

            EnableTextBoxes();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {


        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult iEXIT;
            iEXIT = MessageBox.Show("confirm you want to exit the system", "fast food", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iEXIT == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void RestTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
                {
                    foreach (Control control in controls)
                        if (control is TextBox)
                            (control as TextBox).Text = "0";
                        else
                            func(control.Controls);

                };
            func(Controls);

        }



        private void EnableTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Enabled = false;
                    else
                        func(control.Controls);

            };
            func(Controls);

        }


        private void RestCheckBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is CheckBox)
                        (control as CheckBox).Checked = false;
                    else
                        func(control.Controls);

            };
            func(Controls);

        }




        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RestTextBoxes();
            RestCheckBoxes();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "cash")
            {
                txtpaymentmethod.Enabled = true;
                txtpaymentmethod.Text = "";
                txtpaymentmethod.Focus();

            }
            else
            {
                txtpaymentmethod.Enabled = false;
                txtpaymentmethod.Text = "0";

            }
        }

        private void chkFries_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFries.Checked == true)
            {
                txtFries.Enabled = true;
                txtFries.Text = "";
                txtFries.Focus();
            }
            else
            {
                txtFries.Enabled = false;
                txtFries.Text = "0";

            }
        }

        private void chksalad_CheckedChanged(object sender, EventArgs e)
        {
            if (chksalad.Checked == true)
            {
                txtsalad.Enabled = true;
                txtsalad.Text = "";
                txtsalad.Focus();
            }
            else
            {
                txtsalad.Enabled = false;
                txtsalad.Text = "0";
            }
        }

        private void chkhumburger_CheckedChanged(object sender, EventArgs e)
        {
            if (chkhumburger.Checked == true)
            {
                txthumburger.Enabled = true;
                txthumburger.Text = "";
                txthumburger.Focus();
            }
            else
            {
                txthumburger.Enabled = false;
                txthumburger.Text = "0";

            }

        }

        private void chkonionrings_CheckedChanged(object sender, EventArgs e)
        {
            if (chkonionrings.Checked == true)
            {
                txtonionrings.Enabled = true;
                txtonionrings.Text = "";
                txtonionrings.Focus();
            }
            else
            {
                txtonionrings.Enabled = false;
                txtonionrings.Text = "0";

            }
        }

        private void chkchickensalad_CheckedChanged(object sender, EventArgs e)
        {
            if (chkchickensalad.Checked == true)
            {
                txtchickensalad.Enabled = true;
                txtchickensalad.Text = "";
                txtchickensalad.Focus();
            }
            else
            {
                txtchickensalad.Enabled = false;
                txtchickensalad.Text = "0";

            }
        }

        private void chkcheesesandwich_CheckedChanged(object sender, EventArgs e)
        {
            if (chkcheesesandwich.Checked == true)
            {
                txtcheesesandwich.Enabled = true;
                txtcheesesandwich.Text = "";
                txtcheesesandwich.Focus();
            }
            else
            {
                txtcheesesandwich.Enabled = false;
                txtcheesesandwich.Text = "0";

            }
        }

        private void chkchickensandwich_CheckedChanged(object sender, EventArgs e)
        {
            if (chkchickensandwich.Checked == true)
            {
                txtchickensandwich.Enabled = true;
                txtchickensandwich.Text = "";
                txtchickensandwich.Focus();
            }
            else
            {
                txtchickensandwich.Enabled = false;
                txtchickensandwich.Text = "0";

            }
        }

        private void chkfishsandwich_CheckedChanged(object sender, EventArgs e)
        {
            if (chkfishsandwich.Checked == true)
            {
                txtfishsandwich.Enabled = true;
                txtfishsandwich.Text = "";
                txtfishsandwich.Focus();
            }
            else
            {
                txtfishsandwich.Enabled = false;
                txtfishsandwich.Text = "0";

            }
        }

        private void chkhashbrown_CheckedChanged(object sender, EventArgs e)
        {
            if (chkhashbrown.Checked == true)
            {
                txthashbrown.Enabled = true;
                txthashbrown.Text = "";
                txthashbrown.Focus();
            }
            else
            {
                txthashbrown.Enabled = false;
                txthashbrown.Text = "0";

            }
        }

        private void chktoastedbagel_CheckedChanged(object sender, EventArgs e)
        {
            if (chktoastedbagel.Checked == true)
            {
                txttoastedbagel.Enabled = true;
                txttoastedbagel.Text = "";
                txttoastedbagel.Focus();
            }
            else
            {
                txttoastedbagel.Enabled = false;
                txttoastedbagel.Text = "0";

            }

        }

        private void chkpineapplestick_CheckedChanged(object sender, EventArgs e)
        {
            if (chkpineapplestick.Checked == true)
            {
                txtpineapplestick.Enabled = true;
                txtpineapplestick.Text = "";
                txtpineapplestick.Focus();
            }
            else
            {
                txtpineapplestick.Enabled = false;
                txtpineapplestick.Text = "0";

            }
        }

        private void chkchoclatemuffin_CheckedChanged(object sender, EventArgs e)
        {
            if (chkchoclatemuffin.Checked == true)
            {
                txtchoclatemuffin.Enabled = true;
                txtchoclatemuffin.Text = "";
                txtchoclatemuffin.Focus();
            }
            else
            {
                txtchoclatemuffin.Enabled = false;
                txtchoclatemuffin.Text = "0";

            }
        }

        private void btntotal_Click(object sender, EventArgs e)
        {
            double[] itemcost = new double[22];
            itemcost[0] = Convert.ToDouble(txtFries.Text)*(price_fries);
            itemcost[1] = Convert.ToDouble(txtsalad.Text)*(price_salad);
            itemcost[2] = Convert.ToDouble(txthumburger.Text) * price_humburger;
            itemcost[3] = Convert.ToDouble(txtonionrings.Text) * price_onionrings;
            itemcost[4] = Convert.ToDouble(txtchickensalad.Text) * price_chickensalad;  
            itemcost[5] = Convert.ToDouble(txtfishsandwich.Text) * price_fishsandwich;
            itemcost[6] = Convert.ToDouble(txtcheesesandwich.Text) * price_cheesesandwich;
            itemcost[7] = Convert.ToDouble(txtchickensandwich.Text) * price_chickensandwich;
            itemcost[8] = Convert.ToDouble(txthashbrown.Text) * price_hashbrown;
            itemcost[9] = Convert.ToDouble(txttoastedbagel.Text) * price_toastedbagel;
            itemcost[10] = Convert.ToDouble(txtpineapplestick.Text) * price_pineapplestick;
            itemcost[11] = Convert.ToDouble(txtchoclatemuffin.Text) * price_choclatemuffin;
            itemcost[12] = Convert.ToDouble(txtsyrup.Text) * price_pancakessyrup;
            itemcost[13] = Convert.ToDouble(txttea.Text) * price_tea;
            itemcost[14] = Convert.ToDouble(txtcola.Text) * price_cola;
            itemcost[15] = Convert.ToDouble(txtcoffee.Text) * price_coffee;
            itemcost[16] = Convert.ToDouble(txtsprite.Text) * price_sprite;
            itemcost[17] = Convert.ToDouble(txtpepsi.Text) * price_pepsi;
            itemcost[18] = Convert.ToDouble(txtvanilacone.Text) * price_vanilacone;
            itemcost[19] = Convert.ToDouble(txtvanilashake.Text) * price_vanilashake;
            itemcost[20] = Convert.ToDouble(txtstrawberryshake.Text) * price_strawberryshake;
            itemcost[21] = Convert.ToDouble(txtchoclatemilkshake.Text) * price_choclatemilkshake;


            double cost,ichange;

            if (comboBox1.Text == "cash")  
            {

                isubtotal = itemcost[0] + itemcost[1] + itemcost[2] + itemcost[3] + itemcost[4] + itemcost[5] + itemcost[6] + itemcost[7] + itemcost[8] + itemcost[9] +
                    itemcost[10] + itemcost[11] + itemcost[12] + itemcost[13] + itemcost[14] + itemcost[15] + itemcost[16] + itemcost[17] + itemcost[18] + itemcost[19] +
                    itemcost[20] + itemcost[21];

                lblsubtotal.Text = Convert.ToString(isubtotal);
                itax = (isubtotal * tax_rate) / 100;
                lbltax.Text = Convert.ToString(itax);
                itotal = (isubtotal + itax);
                lbltotal.Text = Convert.ToString(itotal);

                ichange = Convert.ToDouble(txtpaymentmethod.Text);
                cost = ichange - (itax + isubtotal);
                lblchange.Text = Convert.ToString(cost);


               


            }
           
           
            
        }

        private void txttea_TextChanged(object sender, EventArgs e)
        {

        }

        private void txthashbrown_TextChanged(object sender, EventArgs e)
        {

        }

        private void chktea_CheckedChanged(object sender, EventArgs e)
        {
            if (chktea.Checked == true)
            {
                txttea.Enabled = true;
                txttea.Text = "";
                txttea.Focus();
            }
            else
            {
                txttea.Enabled = false;
                txttea.Text = "0";
            }
        }

        private void chkcola_CheckedChanged(object sender, EventArgs e)
        {
            if (chkcola.Checked == true)
            {
                txtcola.Enabled = true;
                txtcola.Text = "";
                txtcola.Focus();
            }
            else
            {
                txtcola.Enabled = false;
                txtcola.Text = "0";
            }

        }

        private void chkcoffee_CheckedChanged(object sender, EventArgs e)
        {

            if (chkcoffee.Checked == true)
            {
                txtcoffee.Enabled = true;
                txtcoffee.Text = "";
                txtcoffee.Focus();
            }
            else
            {
                txtcoffee.Enabled = false;
                txtcoffee.Text = "0";
            }

        }

        private void chksprite_CheckedChanged(object sender, EventArgs e)
        {
            if (chksprite.Checked == true)
            {
                txtsprite.Enabled = true;
                txtsprite.Text = "";
                txtsprite.Focus();
            }
            else
            {
                txtsprite.Enabled = false;
                txtsprite.Text = "0";
            }
        

        }

        private void chkpepsi_CheckedChanged(object sender, EventArgs e)
        {

            if (chkpepsi.Checked == true)
            {
                txtpepsi.Enabled = true;
                txtpepsi.Text = "";
                txtpepsi.Focus();
            }
            else
            {
                txtpepsi.Enabled = false;
                txtpepsi.Text = "0";
            }
        

        }

        private void txtvanilacone_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void chkvanilacone_CheckedChanged(object sender, EventArgs e)
        {
            if (chkvanilacone.Checked == true)
            {
                txtvanilacone.Enabled = true;
                txtvanilacone.Text = "";
                txtvanilacone.Focus();
            }
            else
            {
                txtvanilacone.Enabled = false;
                txtvanilacone.Text = "0";
            }
        }

        private void chkvanilashake_CheckedChanged(object sender, EventArgs e)
        {
            if (chkvanilashake.Checked == true)
            {
                txtvanilashake.Enabled = true;
                txtvanilashake.Text = "";
                txtvanilashake.Focus();
            }
            else
            {
                txtvanilashake.Enabled = false;
                txtvanilashake.Text = "0";
            }
        }

        private void chkstrawberryshake_CheckedChanged(object sender, EventArgs e)
        {
            if (chkstrawberryshake.Checked == true)
            {
                txtstrawberryshake.Enabled = true;
                txtstrawberryshake.Text = "";
                txtstrawberryshake.Focus();
            }
            else
            {
                txtstrawberryshake.Enabled = false;
                txtstrawberryshake.Text = "0";
            }
        }

        private void chkchoclatemilkshake_CheckedChanged(object sender, EventArgs e)
        {
            if (chkchoclatemilkshake.Checked == true)
            {
                txtchoclatemilkshake.Enabled = true;
                txtchoclatemilkshake.Focus();
            }
            else
            {
                txtchoclatemilkshake.Enabled = false;
                txtchoclatemilkshake.Text = "0";
            }

        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpaymentmethod_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
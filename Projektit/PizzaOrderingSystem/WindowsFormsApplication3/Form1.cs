using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Item : Form
    {
        public Item(string nimi, int maara, double hinta)

        {
            this.Nimi = nimi;
            this.Maara = maara;
            this.Hinta = hinta;
        }

        public Item()
        {
            InitializeComponent();
        }

        public string Nimi { get; set; }
        public int Maara { get; set; }
        public double Hinta { get; set; }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Pizzatyypin valinta
            List<Item> ostokset = new List<Item>();
            

            if (radioButton1.Checked == true)
            {
                if (radioButton5.Checked == true)
                {
                    ostokset.Add(new Item("Normal Crust Small Pizza", 1, 4.00));

                }
                else if (radioButton6.Checked == true)
                {
                    ostokset.Add(new Item("Cheesy Crust Small Pizza", 1, 4.00));

                }
                else if (radioButton7.Checked == true)
                {
                    ostokset.Add(new Item("Sausage Crust Small Pizza", 1, 4.00));

                }

            }

            else if (radioButton2.Checked == true)
            {
                if (radioButton5.Checked == true)
                {
                    ostokset.Add(new Item("Normal Crust medium Pizza", 1, 7.00));

                }
                else if (radioButton6.Checked == true)
                {
                    ostokset.Add(new Item("Cheesy Crust Medium Pizza", 1, 7.00));

                }
                else if (radioButton7.Checked == true)
                {
                    ostokset.Add(new Item("Sausage Crust Medium Pizza", 1, 7.00));

                }
            }

            else if (radioButton3.Checked == true)
            {
                if (radioButton5.Checked == true)
                {
                    ostokset.Add(new Item("Normal Crust Large Pizza", 1, 10.00));


                }
                else if (radioButton6.Checked == true)
                {
                    ostokset.Add(new Item("Cheesy Crust Large Pizza", 1, 10.00));

                }
                else if (radioButton7.Checked == true)
                {
                    ostokset.Add(new Item("Sausage Crust Large Pizza", 1, 10.00));

                }
            }

            else if (radioButton4.Checked == true)
            {
                if (radioButton5.Checked == true)
                {
                    ostokset.Add(new Item("Normal Crust Extra Large Pizza", 1, 13.00));
                    

                }
                else if (radioButton6.Checked == true)
                {
                    ostokset.Add(new Item("Cheesy Crust Extra Large Pizza", 1, 13.00));


                }
                else if (radioButton7.Checked == true)
                {
                    ostokset.Add(new Item("Sausage Crust Extra Large Pizza", 1, 13.00));


                }
            }


            //Pizza täytteiden valinta

            if (checkBox1.Checked == true)
            {

                ostokset.Add(new Item("Pepperoni Toppings", 1, 0.75));

            }

            if (checkBox2.Checked == true)
            {
                ostokset.Add(new Item("Extra Cheese Toppings", 1, 0.75));
            }

            if (checkBox3.Checked == true)
            {
                ostokset.Add(new Item("Mushroom Toppings", 1, 0.75));
            }

            if (checkBox4.Checked == true)
            {
                ostokset.Add(new Item("Ham Toppings", 1, 0.75));
            }

            if (checkBox5.Checked == true)
            {
                ostokset.Add(new Item("Bacon Toppings", 1, 0.75));
            }

            if (checkBox6.Checked == true)
            {
                ostokset.Add(new Item("Ground Beef Toppings", 1, 0.75));
            }

            if (checkBox7.Checked == true)
            {
                ostokset.Add(new Item("Jalapeno Toppings", 1, 0.75));
            }

            if (checkBox8.Checked == true)
            {
                ostokset.Add(new Item("Pineapple Toppings", 1, 0.75));

            }

            if (checkBox9.Checked == true)
            {
                ostokset.Add(new Item("Dried Shrimps Toppings", 1, 0.75));
            }

            if (checkBox10.Checked == true)
            {
                ostokset.Add(new Item("Anchovies Toppings", 1, 0.75));
            }

            if (checkBox11.Checked == true)
            {
                ostokset.Add(new Item("Sun Dried Tomatoes Toppings", 1, 0.75));
            }

            if (checkBox12.Checked == true)
            {
                ostokset.Add(new Item("Spinach Toppings", 1, 0.75));
            }


            if (checkBox13.Checked == true)
            {
                ostokset.Add(new Item("Roasted Garlic Toppings", 1, 0.75));
            }

            if (checkBox14.Checked == true)
            {
                ostokset.Add(new Item("Shredded Chicken Toppings", 1, 0.75));
            }

            //Juoma valinnat

            if (checkBox15.Checked == true)
            {
                ostokset.Add(new Item("Coke - Can", 1, 1.45));
            }

            if (checkBox16.Checked == true)
            {
                ostokset.Add(new Item("Diet Coke - Can", 1, 1.45));
            }

            if (checkBox17.Checked == true)
            {
                ostokset.Add(new Item("Iced Tea - Can", 1, 1.45));

            }

            if (checkBox18.Checked == true)
            {
                ostokset.Add(new Item("Ginger Ale - Can", 1, 1.45));
            }


            if (checkBox19.Checked == true)
            {
                ostokset.Add(new Item("Diet Coke - Can", 1, 1.45));
            }

            if (checkBox20.Checked == true)
            {
                ostokset.Add(new Item("Sprite - Can", 1, 1.45));
            }


            if (checkBox21.Checked == true)
            {
                ostokset.Add(new Item("Bottled Water", 1, 1.25));
            }

            //Muut tuotteet

            if (checkBox22.Checked == true)
            {
                ostokset.Add(new Item("Chicken Wings", 1, 3.00));

            }

            if (checkBox23.Checked == true)
            {
                ostokset.Add(new Item("Poutine", 1, 3.00));

            }

            if (checkBox24.Checked == true)
            {
                ostokset.Add(new Item("Onion Rings", 1, 3.00));

            }

            if (checkBox25.Checked == true)
            {
                ostokset.Add(new Item("Cheesy Garlic Bread", 1, 3.00));

            }

            if (checkBox26.Checked == true)
            {
                ostokset.Add(new Item("Garlic Dip", 1, 0.00));

            }


            if (checkBox27.Checked == true)
            {
                ostokset.Add(new Item("BBQ Dip", 1, 0.00));

            }

            if (checkBox28.Checked == true)
            {
                ostokset.Add(new Item("Sour Cream Dip", 1, 0.00));
            }

            try
            {
                double total = 00.00;
                double hst = 00.00;
                double totaldue = 00.00;

                foreach (var ostos  in ostokset)
                {

                    total += ostos.Hinta;
                }


                hst = total * 0.13;
                totaldue = hst + total;
      

                string hstDisplay = hst.ToString("c2");
                string totalDisplay = totaldue.ToString("c2");
                string amount = total.ToString("c2");

                
                textBox8.Text = amount;
                textBox9.Text = hstDisplay;
                textBox10.Text = totalDisplay;

                tabControl1.SelectTab("tabPage2");
            }
            catch (Exception)
            {


                tabControl1.SelectTab("tabPage2");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage1");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage3");
            textBox19.Text = textBox10.Text;
        }

        //Lataa formin näytölle
        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton5.Checked = true;
            textBox8.Enabled = false;
            textBox9.Enabled = false;
            textBox10.Enabled = false;
            textBox19.Enabled = false;
            textBox21.Enabled = false;
            comboBox1.Items.Add("Ahvenanmaa");
            comboBox1.Items.Add("Uusimaa");
            comboBox1.Items.Add("Varsinais-Suomi");
            comboBox1.Items.Add("Keski-Suomi");
            comboBox1.Items.Add("Satakunta");
            comboBox1.Items.Add("Kanta-Häme");
            comboBox1.Items.Add("Pirkanmaa");
            comboBox1.Items.Add("Päijät-Häme");
            comboBox1.Items.Add("Kymenlaakso");
            comboBox1.Items.Add("Pohjois-Savo");
            comboBox1.Items.Add("Etelä-Savo");
            comboBox1.Items.Add("Etelä-Karjala");
            comboBox1.Items.Add("Pohjois-Karjala");
            comboBox1.Items.Add("Etelä-Pohjanmaa");
            comboBox1.Items.Add("Keski-Pohjanmaa");
            comboBox1.Items.Add("Pohjanmaa");
            comboBox1.Items.Add("Pohjois-Pohjanmaa");
            comboBox1.Items.Add("Kainuu");
            comboBox1.Items.Add("Lappi");

            comboBox2.Items.Add("Cash");
            comboBox2.Items.Add("Credit Card");
            comboBox2.Items.Add("Debit Card");
            comboBox2.Items.Add("Promo Card");

            button8.Enabled = false;

        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox20_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8 && q != 46)
            {
                e.Handled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage2");
        }

        private void button7_Click(object sender, EventArgs e)
        {


            if (textBox11.Text == "" || textBox12.Text == "" || textBox13.Text == "" || textBox15.Text == "" || textBox20.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Please fill in required fields");
            }

            try
            {

                {
                    string money = textBox19.Text;
                    char[] dollars = { '$' };
                    string paymoney = money.TrimStart(dollars);
                    double paymentDue = Convert.ToDouble(paymoney);
                    double amountPaid = Convert.ToDouble(textBox20.Text);
                    double change = 0;
                    change = amountPaid - paymentDue;
                    textBox21.Text = change.ToString("c2");

                    if (change < 0)
                    {
                        MessageBox.Show("Please pay your balance");

                    }
                }
            }
            catch (Exception)
            {
                button8.Enabled = true;
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Thanks for ordering at Pizza Express. Your ordered items will be ready and delivered in 30 minutes. Do you want to order some more?", "Exit", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {


                //Poistaa kaiken datan
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
                checkBox7.Checked = false;
                checkBox8.Checked = false;
                checkBox9.Checked = false;
                checkBox10.Checked = false;
                checkBox11.Checked = false;
                checkBox12.Checked = false;
                checkBox13.Checked = false;
                checkBox14.Checked = false;
                checkBox15.Checked = false;
                checkBox16.Checked = false;
                checkBox17.Checked = false;
                checkBox18.Checked = false;
                checkBox19.Checked = false;
                checkBox20.Checked = false;
                checkBox21.Checked = false;
                checkBox22.Checked = false;
                checkBox23.Checked = false;
                checkBox24.Checked = false;
                checkBox25.Checked = false;
                checkBox26.Checked = false;
                checkBox27.Checked = false;
                checkBox28.Checked = false;


                listView1.Items.Clear();
                textBox8.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";

                textBox11.Text = "";
                textBox12.Text = "";
                textBox13.Text = "";
                textBox14.Text = "";
                textBox15.Text = "";
                textBox16.Text = "";
                textBox17.Text = "";
                textBox18.Text = "";
                textBox19.Text = "";
                textBox20.Text = "";
                textBox21.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";

                tabControl1.SelectTab("tabPage1");
            }

            else if (dialog == DialogResult.No)
            {
                this.Close();
            }


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Cash")
            {
                textBox18.Enabled = false;
            }
        }

    }
}

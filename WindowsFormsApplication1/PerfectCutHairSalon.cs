using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace PerfectCutHairSalon
{
    public partial class PerfectCutHairSalon : Form
    {
        //variable declaration
        ArrayList selectedservices = new ArrayList(); 
        String selectedHairdresser;
        int countprice = 0;
        public PerfectCutHairSalon()
        {
            InitializeComponent();
            services.SelectionMode = SelectionMode.MultiSimple;  
        }

       
        private void add_service(object sender, EventArgs e)
        {
            //event handling on add service button
            //get selected hairdresser from combobox and add it to the chargeditems listbox
            //get selected services from listbox and add it to the chargeditems listbox
            selectedHairdresser = hairdresser.Items[hairdresser.SelectedIndex].ToString();
            chargeditems.Items.Add(selectedHairdresser);
            //add value for selected hairdresser
            if (selectedHairdresser == "Jane")
            {
                pricebox.Items.Add("$30.00");
                countprice = countprice + 30;
            }
            else if (selectedHairdresser == "Pat")
            {
                pricebox.Items.Add("$45.00");
                countprice = countprice + 45;
            }
            else if (selectedHairdresser == "Ron")
            {
                pricebox.Items.Add("$40.00");
                countprice = countprice + 40;
            }
            else if (selectedHairdresser == "Sue")
            {
                pricebox.Items.Add("$50.00");
                countprice = countprice + 50;
            }
            else if (selectedHairdresser == "Laurie")
            {
                pricebox.Items.Add("$55.00");
                countprice = countprice + 55;
            }
            //disable hairdresser combobox once it's added to chargeditems listbox
            hairdresser.Enabled = false; 
            foreach (var list in services.SelectedItems)
            {
                //create a arraylist containing each selected items in services listbox
                selectedservices.Add(list.ToString());
                chargeditems.Items.Add(list.ToString());
            }
            foreach (var z in selectedservices)
            {
                //add value for selected service
                if (z == "Cut")
                {
                    pricebox.Items.Add("$30.00");
                    countprice = countprice + 30;
                }
                else if (z == "Wash, blow-dry, and style")
                {
                    pricebox.Items.Add("$20.00");
                    countprice = countprice + 20;
                }
                else if (z == "Colour")
                {
                    pricebox.Items.Add("$40.00");
                    countprice = countprice + 40;
                }
                else if (z == "Highlights")
                {
                    pricebox.Items.Add("$50.00");
                    countprice = countprice + 50;
                }
                else if (z == "Extension")
                {
                    pricebox.Items.Add("$200.00");
                    countprice = countprice + 200;
                }
                else if (z == "Up-do")
                {
                    pricebox.Items.Add("$60.00");
                    countprice = countprice + 60;
                }
            }          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //set total prize as text on totlePriceLable 
            totalPriceLable.Text = "$" + countprice.ToString() + ".00";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //clear all selected items in combobox and listbox
            countprice = 0;
            chargeditems.Items.Clear();
            pricebox.Items.Clear();
            hairdresser.Enabled = true;
            services.ClearSelected();
            totalPriceLable.Text = "";
            selectedservices.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //exit form 
            this.Close();
        }
       
        
    }
}

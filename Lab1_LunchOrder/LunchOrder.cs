using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_LunchOrder
{

    /* This program is a Lunch Order form that accepts order of one Main Course with Add-on selections depending on Main Course
       selected. It also calculates the subtotal and total of the order with 5% tax added.    
        
       Date: April 2021
       Author: Cecilia Santiago
     */


    public partial class frmLunchOrder : Form
    {
        
        const decimal hambprice = 6.95m;        //price of one hamburger
        const decimal pizzaprice = 5.95m;       //price of one pizza
        const decimal saladprice = 4.95m;       //price of one order of salad
        const decimal tax = 0.05m;              //5% tax to be added to the subtotal

        //Each add-on for a particular choice of main course has the same price
        decimal hambaddon = .75m;               //add-on price of $.75 for hamburger
        decimal pizzaaddon = .50m;              //add-on price of $.50 for pizza
        decimal saladaddon = .25m;              //add-on price of $.25 for salad
        decimal totaddon = 0.0m;                //total of add-ons per main course
        decimal subtotal = 0.0m;                //total of maincourse with add-ons
        decimal price = 0.0m;                   //temporary holder of price of hamburger, pizza, salad

        public frmLunchOrder()
        {
            InitializeComponent();
        }

        //Exit the whole applications when Exit button or  when "x" or Alt+x is clicked
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //Reinitializes all variables and labels and radiobuttons and checkboxes that were checked 
        private void btnReset_Click(object sender, EventArgs e)
        {
            rbtnHamb.Checked = true;            //Hamburger Main course is the default selection         
            rbtnPizza.Checked = false;
            rbtnSalad.Checked = false;

            grpAddonsHamb.Visible = true;       //Hamburger add-ons is the default add-ons
            grpAddonsPizza.Visible = false;
            grpAddonsSalad.Visible = false;

            InitializeVariables();              //Call to initialize all labels, checkboxes and totals
            price = hambprice;                  //sets the default price to hamburger price

        }

        //Set all variables and labels to blank and totals to 0 and uncheck all Checkboxes
        private void InitializeVariables()
        {
            chkCroutons.Checked = false;
            chkBaconBits.Checked = false;
            chkBreadSticks.Checked = false;

            chkLettuce.Checked = false;
            chkKetchup.Checked = false;
            chkFrenchFries.Checked = false;

            chkPepperoni.Checked = false;
            chkSausage.Checked = false;
            chkOlives.Checked = false;

            lblSubTotalText.Text = "";
            lblTaxText.Text = "";
            lblOrderTotalText.Text = "";
            totaddon = 0.0m;
            subtotal = 0.0m;
        }

        //Displays the subtotal, tax and order total when Place Order is clicked
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
           
            subtotal = price + totaddon;                                                //price of main course with add-ons
            lblSubTotalText.Text = subtotal.ToString("c");                              //display price of main course with add-ons
            lblTaxText.Text = CalculateTaxAmt(subtotal).ToString("c");                  //get the 5% of subtotal and display
            lblOrderTotalText.Text = CalculateOrderTotal(subtotal).ToString("c");       //get the total of subtotal and tax and display

        }

        //Calculates the tax portion of the price of main course with add-ons
        private decimal CalculateTaxAmt(decimal subt)           //subt = price of main course with add-ons
        {
            return subt * tax;
        }

        //Calculates the price of main course with add-ons plus tax
        private decimal CalculateOrderTotal(decimal subt)       //subt = price of main course with add-ons
        {
            return subt + (subt * tax);
        }

        //Main Course selection. Only one main course can be selected
        private void rbtn_CheckedChanged(object sender, EventArgs e)
        {

            InitializeVariables();                            //Call to initialize all labels, checkboxes and totals

            RadioButton mainchoice = (RadioButton)sender;  

            switch (mainchoice.Name)
            {
                case "rbtnPizza":                             //Select Pizza. Only Pizza add-ons will display
                    grpAddonsPizza.Visible = true;                    
                    grpAddonsHamb.Visible = false;                    
                    grpAddonsSalad.Visible = false;  
                    price = pizzaprice;                                      
                    break;

                case "rbtnSalad":                             //Select Salad. Only Salad add-ons will display
                    grpAddonsSalad.Visible = true;                    
                    grpAddonsPizza.Visible = false;                    
                    grpAddonsHamb.Visible = false;  
                    price = saladprice;
                    break;

                default:                                      //Hamburger is default selection. Only Hamburger add-ons will display
                    grpAddonsHamb.Visible = true;                    
                    grpAddonsPizza.Visible = false;                    
                    grpAddonsSalad.Visible = false;                    
                    price = hambprice;                    
                    break;
            }

        }

        //Ad-on selection dpending on the Main Course. 
        private void chk_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox addon = (CheckBox)sender;

            switch (addon.Name)
            {
                //chkCroutons, chkBaconBits, chkBreadSticks are Salad add-ons. Add if checked, subtract if unchecked
                case "chkCroutons":
                    if (chkCroutons.Checked)
                        totaddon += saladaddon;
                    else
                        totaddon -= saladaddon;
                    break;

                case "chkBaconBits":
                    if (chkBaconBits.Checked)
                        totaddon += saladaddon;
                    else
                        totaddon -= saladaddon;
                    break;

                case "chkBreadSticks":
                    if (chkBreadSticks.Checked)
                        totaddon += saladaddon;
                    else
                        totaddon -= saladaddon;
                    break;

                //chkPepperoni, chkSausage, chkOlives are Pizza add-ons. Add if checked, subtract if unchecked
                case "chkPepperoni":
                    if (chkPepperoni.Checked)
                        totaddon += pizzaaddon;
                    else
                        totaddon -= pizzaaddon;
                    break;

                case "chkSausage":
                    if (chkSausage.Checked)
                        totaddon += pizzaaddon;
                    else
                        totaddon -= pizzaaddon;
                    break;

                case "chkOlives":
                    if (chkOlives.Checked)
                        totaddon += pizzaaddon;
                    else
                        totaddon -= pizzaaddon;
                    break;

                //chkKetchup, chkFrencFries are Hamburger add-ons. Add if checked, subtract if unchecked
                case "chkKetchup":
                    if (chkKetchup.Checked)
                        totaddon += hambaddon;
                    else
                        totaddon -= hambaddon;
                    break;

                case "chkFrenchFries":
                    if (chkFrenchFries.Checked)
                        totaddon += hambaddon;
                    else
                        totaddon -= hambaddon;
                    break;

                default:            ///chkLettuce is a Hamburger add-ons. Add if checked, subtract if unchecked
                    if (chkLettuce.Checked)
                        totaddon += hambaddon;
                    else
                        totaddon -= hambaddon;
                    break;

            }
        }
    }
}

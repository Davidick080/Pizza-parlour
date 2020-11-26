using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Pizza_parlour
    //Name:David 
    //Nov,26,2020
    //Basis summary
    //Basic cash register simulation 
{
    public partial class Form1 : Form
    {//Global variables 
        //For calculator
        Double dough=5;
        int costofdoughr;
        Double moneyfromDough;
       

        Double toppings=2;
        int costoftoppings;
        Double moneyfromToppings;

        Double Maple=50;
        int costofMaple;
        Double MoneyfromMaple;

        //For calculator & recept
        Double cost;

        //For recept 

        Double amounttax;
        Double tax = 1.13;
        Double Smalltax= 0.13;
        Double totalCost;
        // For change 
        Double Money;
        Double change;
        Double moneyowed;
        Double moneycharged;
        public Form1()
        {
            InitializeComponent();
        }
        //This button is for the calculator 
        private void Button1_Click(object sender, EventArgs e)
            
        {
            try
            {
                costofdoughr = Convert.ToInt32(Costofdough.Text);
                moneyfromDough = dough * costofdoughr;

                costoftoppings = Convert.ToInt32(Toppings.Text);
                moneyfromToppings = toppings * costoftoppings;

                costofMaple = Convert.ToInt32(textBox2.Text);
                MoneyfromMaple = Maple * costofMaple;
            
        
            
            
                cost = moneyfromDough + moneyfromToppings + MoneyfromMaple;

                Screen2.Text = $"The cost of pizza  {moneyfromDough.ToString("c")} \nThe cost of toppings will be { moneyfromToppings.ToString("c")} \n cost of maple syrup is ehh {MoneyfromMaple.ToString("c")} \n\n total cost is {cost.ToString("c")} ";
            }


            catch
            {
                Screen2.Text = $"Sorry ehh use only numbers ehhh";
            }


        }

        //This is the change owed change  
        private void Change_Click(object sender, EventArgs e)
        {
            try
            {
                Money = Convert.ToDouble(textBox3.Text);
                moneycharged = cost;
                moneyowed = Money - moneycharged;
                Changeowed.Text = $"Change owed {moneyowed.ToString("c")}";
            }


            catch
            { Changeowed.Text = $"not compatable"; }
        }

        //Second button is print recipt 
        private void Button2_Click(object sender, EventArgs e)
            
        { try
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.cash);
                amounttax = cost * Smalltax;
                totalCost = cost * tax;
                player.Play();
                Screen.Text = $"The Canadian pizza store";
                Refresh();
                Thread.Sleep(1000);
                player.Play();
                Screen.Text+=    $"\nPizza              {moneyfromDough.ToString("c")}";
                Refresh();
                Thread.Sleep(1000);
                player.Play();
                Screen.Text+=$"\nToopings       {moneyfromToppings.ToString("c")}";
                  Refresh();
                Thread.Sleep(1000);
                player.Play();
                Screen.Text+=$"\nMaple syrup  {MoneyfromMaple.ToString("c")} ";
                Refresh();
                Thread.Sleep(1000);
                player.Play();
                Screen.Text+=$"\n\nCost               {cost.ToString("c")} ";
                Refresh();
                Thread.Sleep(1000);
                player.Play();
                Screen.Text+=$"\nTax                 {amounttax.ToString("c")} ";
                Refresh();
                Thread.Sleep(1000);
                player.Play();
                Screen.Text+=$"\nTotal cost      {totalCost.ToString("c")} ";
                Refresh();
                Thread.Sleep(1000);
                player.Play();
                Screen.Text += $"\n\nMoney            {Money.ToString("c")}";
                Refresh();
                Thread.Sleep(1000);
                player.Play();
                Screen.Text += $"\nchange           {moneyowed.ToString("c")}";
                Refresh();
                Thread.Sleep(1000);
                player.Play();
                Screen.Text+=$"\n\n Have a nice day.  ";

            }
            catch
            {
                Screen.Text = $"only numbers ok";
            }
        }
    }
}

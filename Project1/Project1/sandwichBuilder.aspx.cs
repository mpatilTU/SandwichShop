using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project1
{
    public partial class sandwichBuilder : System.Web.UI.Page
    {
        public sandwichBuilder()
        {
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //get requested values
            String name = Request["name"];
            String phone = Request["phone"];
            String toasted = Request["toast"];
            String size = Request["size"];
            String spreads = Request["spread"];
            String toppings = Request["toppings"];
            String ptoppings = Request["ptoppings"];
            String meal = Request["meal"];
            String drinks = Request["drinks"];
            String sides = Request["sides"];
            String tip = Request["tip"];
            double TotalPrice = 0;
            
            //display order values
            lblName.Text = name;
            lblPhone.Text = phone;
            lblToasted.Text = toasted;
            lblSize.Text = size;
            lblSpreads.Text = spreads;
            lblToppings.Text = toppings;
            lblpToppings.Text = ptoppings;
            lblMeal.Text = meal;
            lblDrink.Text = drinks;
            lblSide.Text = sides;
            lblTip.Text = "$" + tip;

            //display total price
            order order1 = new order();
            TotalPrice = order1.CalculateOrderTotal(toasted, size, spreads, toppings, ptoppings, meal, drinks, sides, tip);
            lblTotal.Text = "$" + TotalPrice.ToString(); 
        }
    }
}
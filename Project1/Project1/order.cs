using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project1
{
    public class order
    {

        //bread
        double toast = 1.50;
        double untoast = 0.00;
        //size
        double fourin = 4.00;
        double sixin = 6.00;
        double twelvein = 8.00;
        //spreads
        double mayo = .50;
        double avocadoRanch = 1.00;
        double italianDressing = 0.50;
        double sweetOnion = 0.50;
        double spicyChipotle = 0.75;
        //toppings
        double tomatoes = 0.35;
        double onions = 0.35;
        double lettuce = 0.30;
        double spinach = 0.40;
        double jalapeño = 0.75;
        //premium topppings
        double chicken = 1.00;
        double bacon = 1.00;
        double pepperoni = 1.00;
        double extraCheese = 1.00;
        double olives = 1.00;
        //meal
        double ymeal = 3.00;
        //drinks
        double coke = 0.70;
        double pepsi = 0.70;
        double mdew = 0.70;
        //sides 
        double cookies = 1.00;
        double fruits = 1.00;
        double chips = 1.49;
        //tax
        double tax = 0.06;
        //tip
        double tips = 0.00;
        //total
        double total = 0.00;

        public double CalculateOrderTotal(string toasted, string size, string spreads, string toppings, string ptoppings, string meal, string drinks, string sides, string tip) 
        {
            if (toasted.Contains("Toasted"))
            {
                total += toast;
            }
            if (toasted.Contains("Untoasted"))
            {
                total += untoast;
            }
            if (size.Contains("4 inches"))
            {
                total += fourin;
            }
            if (size.Contains("6 inches"))
            {
                total += sixin;
            }
            if (size.Contains("12 inches"))
            {
                total += twelvein;
            }
            if (spreads.Contains("Mayo"))
            {
                total += mayo;
            }
            if (spreads.Contains("AvocadoRanch"))
            {
                total += avocadoRanch;
            }
            if (spreads.Contains("Italian"))
            {
                total += italianDressing;
            }
            if (spreads.Contains("Sweet"))
            {
                total += sweetOnion;
            }
            if (spreads.Contains("Spicy"))
            {
                total += spicyChipotle;
            }
            if (toppings.Contains("Tomatoes"))
            {
                total += tomatoes;
            }
            if (toppings.Contains("Onions"))
            {
                total += onions;
            }
            if (toppings.Contains("Lettuce"))
            {
                total += lettuce;
            }
            if (toppings.Contains("Spinach"))
            {
                total += spinach;
            }
            if (toppings.Contains("Jalapeno"))
            {
                total += jalapeño;
            }
            if (ptoppings.Contains("Chicken"))
            {
                total += chicken;
            }
            if (ptoppings.Contains("Bacon"))
            {
                total += bacon;
            }
            if (ptoppings.Contains("Peperoni"))
            {
                total += pepperoni;
            }
            if (ptoppings.Contains("Extra Cheese"))
            {
                total += extraCheese;
            }
            if (ptoppings.Contains("Olives"))
            {
                total += olives;
            }
            if (meal.Contains("Yes"))
            {
                total += ymeal;

                if (drinks.Contains("Coke"))
                {
                    total += coke;
                }
                if (drinks.Contains("Pepsi"))
                {
                    total += pepsi;
                }
                if (drinks.Contains("Mountain Dew"))
                {
                    total += mdew;
                }
                if (sides.Contains("Cookies"))
                {
                    total += cookies;
                }
                if (sides.Contains("Chips"))
                {
                    total += chips;
                }
                if (sides.Contains("Fruits"))
                {
                    total += fruits;
                }
            }
            

            total += total * tax;

            if (tip != null)
            {
                tips += double.Parse(tip);
                total += tips;
            }
            return total;
        }
  


    }
}
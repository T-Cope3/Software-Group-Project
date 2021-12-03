using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Group_Project
{
    internal class Pizzas
    {
        public String crust;
        public String sauce;
        public String size;
        public int toppings = 0;
        public String beverage;
        public String beverage_size;
        public double tip = 0;
        public void clear()
        {
            crust = null;
            sauce = null;
            size = null;
            toppings = 0;
            beverage = null;
            beverage_size = null;
            tip = 0;
        }

    }

    
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Menu.Entrees
{
    public class Brontowurst
    {
        private bool brautwurst = true;
        private bool wholeWheatBun = true;
        private bool peppers = true;
        private bool onion = true;

        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Whole Wheat Bun" };
                if (brautwurst) ingredients.Add("Brautwurst");
                if (peppers) ingredients.Add("Peppers");
                if (onion) ingredients.Add("Onion");
                return ingredients;
            }
        }

        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }

        public void HoldBun()
        {
            this.wholeWheatBun = false;
        }

        public void HoldPeppers()
        {
            this.peppers = false;
        }

        public void HoldOnion()
        {
            this.onion = false;
        }



    }
}

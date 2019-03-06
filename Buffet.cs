using System;
using System.Collections.Generic;

namespace _08HungryNinja {
    public class Buffet {
        public List<Food> Menu; 
        // add a constructor and set Menu to a hard coded list of 7 or more Food objects you instantiate manually
        public Buffet () {
            Menu = new List<Food> () {
                new Food ("Slice of Cheese Pizza", 277, false, false),
                new Food ("Tiramisu", 240, false, true),
                new Food ("Steak Taco", 250, true, false),
                new Food ("Egg Salad Sandwich", 600, false, false),
                new Food ("Pad Thai", 940, true, false),
                new Food ("Snickers Bar", 215, false, true),
                new Food ("Mac and Cheese", 310, false, false),
            };
        }
        // build out a Serve method that randomly selects a Food object from the Menu list and returns the Food object
        Random rand = new Random ();
        public Food Serve () {
            return Menu[rand.Next(Menu.Count)];
        }
    }
}
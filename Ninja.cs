using System;
using System.Collections.Generic;

namespace _08HungryNinja {
    public class Ninja {

        private int calorieIntake;
        public int CalorieAmount {
            get {
                return calorieIntake;
            }
        }
        public List<Food> FoodHistory;
        // add a constructor that sets calorieIntake to 0 and creates a new, empty list of Food objects to FoodHistory
        public Ninja () {
            calorieIntake = 0;
            FoodHistory = new List<Food> () { };
        }
        // add a public "getter" property called "IsFull" that returns a boolean based on if the Ninja's calorie intake is greater than 1200 calories
        public bool IsFull {
            get {
                bool full = false;
                if (calorieIntake > 1200) {
                    full = true;
                }
                return full;
            }
        }
        // build out the Eat method that: if the Ninja is NOT full:
        //  adds calorie value to ninja's total calorieIntake
        //  adds the randomly selected Food object to ninja's FoodHistory list
        //  writes the Food's Name - and if it is spicy/sweet to the console

        // if the Ninja IS full
        //  issues a warning to the console that the ninja is full and cannot eat anymore
        
        public void Eat (Food item) {
            calorieIntake += item.Calories;
            FoodHistory.Add(item);
            Console.WriteLine($"Food name: {item.Name}, Spicy: {item.IsSpicy}, Sweet: {item.IsSweet}");
        }
    }
}
using System;

namespace _08HungryNinja {
    class Program {
        static void Main (string[] args) {
            // In your Program's Main method, instantiate a Buffet and Ninja object, and have the Ninja eat until they are full!
            Buffet ninjaBuffet = new Buffet ();
            Ninja ciso = new Ninja ();
            while (ciso.IsFull == false) {
                ciso.Eat (ninjaBuffet.Serve ());
            }
            Console.WriteLine ($"Warning: calorie intake is {ciso.CalorieAmount}. Your ninja is full.");
        }
    }
}
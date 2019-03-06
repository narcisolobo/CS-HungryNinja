namespace _08HungryNinja {
    public class Food {
        public string Name;
        public int Calories;
        // Foods can be Spicy and/or Sweet
        public bool IsSpicy;
        public bool IsSweet;
        // add a constructor that takes in all three parameters: Name, Calories, IsSpicy, IsSweet
        public Food (string n, int c, bool spicy, bool sweet) {
            Name = n;
            Calories = c;
            IsSpicy = spicy;
            IsSweet = sweet;
        }
    }
}
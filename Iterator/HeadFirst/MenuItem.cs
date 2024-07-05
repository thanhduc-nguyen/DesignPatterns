namespace Iterator.HeadFirst
{
    public class MenuItem(string name, string description, bool vegetarian, double price)
    {
        public string Name { get; set; } = name;
        public string Description { get; set; } = description;
        public bool Vegetarian { get; set; } = vegetarian;
        public double Price { get; set; } = price;
    }
}


namespace Composite.HeadFirst
{
    public class MenuItem(string name, string description, bool vegetarian, decimal price) : MenuComponent
    {
        public override string Name { get => name; }
        public override string Description { get => description; }
        public override bool Vegetarian { get => vegetarian; }
        public override decimal Price { get => price; }

        public override void Print()
        {
            Console.Write($"  {Name}");
            if (Vegetarian)
            {
                Console.Write("(v)");
            }
            Console.WriteLine($", {Price}");
            Console.WriteLine($"   -- {Description}");
        }

        public override IEnumerator<MenuComponent> CreateIterator()
        {
            return new NullIterator();
        }
    }
}

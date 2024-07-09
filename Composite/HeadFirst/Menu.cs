namespace Composite.HeadFirst
{
    public class Menu(string name, string description) : MenuComponent
    {
        private List<MenuComponent> _menuComponents = [];
        public override string Name { get => name; }
        public override string Description { get => description; }

        public override void Add(MenuComponent menuComponent)
        {
            _menuComponents.Add(menuComponent);
        }

        public override void Remove(MenuComponent menuComponent)
        {
            _menuComponents.Remove(menuComponent);
        }

        public override MenuComponent GetChild(int i)
        {
            return _menuComponents[i];
        }

        public override void Print()
        {
            Console.Write($"\n {Name}");
            Console.WriteLine($", {Description}");
            Console.WriteLine(" ---------------------");

            var iterator = _menuComponents.GetEnumerator();
            while (iterator.MoveNext())
            {
                MenuComponent menuComponent = iterator.Current;
                menuComponent.Print();
            }
        }

        public override IEnumerator<MenuComponent> CreateIterator()
        {
            return new CompositeIterator(_menuComponents.GetEnumerator());
        }
    }
}

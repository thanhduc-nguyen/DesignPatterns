namespace Prototype.RefactoringGuru
{
    public class PrototypeRegistry
    {
        private static readonly Lazy<PrototypeRegistry> _instance = new Lazy<PrototypeRegistry>(() => new PrototypeRegistry());
        private List<IClone> _items = new List<IClone>();

        private PrototypeRegistry()
        {
        }

        public static PrototypeRegistry Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        public void AddItem(IClone item)
        {
            _items.Add(item);
        }

        public IClone GetItem(int Id)
        {
            return _items[Id];
        }
    }
}

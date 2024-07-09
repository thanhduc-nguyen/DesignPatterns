namespace Composite.RefactoringGuru
{
    public class Box(string name) : IItem
    {
        private List<IItem> Items { get; set; } = [];

        public string Name { get => name; }
        public decimal Price { get; set; } = 0;

        public void AddItem(IItem item)
        {
            Items.Add(item);
        }

        public decimal TotalPrice()
        {
            decimal result = 0;
            foreach (var item in Items)
            {
                result += item.TotalPrice();
            }

            result += Price;

            return result;
        }
    }
}

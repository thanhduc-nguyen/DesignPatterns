namespace Composite.RefactoringGuru
{
    public class Product(string name) : IItem
    {
        public string Name { get => name; }
        public decimal Price { get; set; } = 0;

        public decimal TotalPrice()
        {
            return Price;
        }
    }
}

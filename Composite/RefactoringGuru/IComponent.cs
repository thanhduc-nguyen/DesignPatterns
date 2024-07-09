namespace Composite.RefactoringGuru
{
    public interface IItem
    {
        public string Name { get; }
        public decimal Price { get; set; }

        public decimal TotalPrice();
    }
}

namespace Decorator.HeadFirst
{
    public abstract class Beverage
    {
        public virtual string Description { get; set; } = "Unknown Beverage";
        public virtual Size Size { get; set; } = Size.Grande;

        public abstract double Cost();
    }
}

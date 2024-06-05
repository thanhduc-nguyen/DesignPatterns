namespace Decorator.HeadFirst
{
    public abstract class Beverage
    {
        public virtual string Description { get; set; } = "Unknown Beverage";

        public abstract double Cost();
    }
}

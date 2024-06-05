namespace Decorator.HeadFirst
{
    public abstract class CondimentDecorator : Beverage
    {
        public abstract override string Description { get; set; }
    }
}

namespace Decorator.HeadFirst
{
    public class Soy : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public Soy(Beverage beverage)
        {
            _beverage = beverage;
            Description = _beverage.Description;
        }

        public override string Description { get; set; }

        public override double Cost()
        {
            return _beverage.Cost() + 0.15;
        }
    }
}

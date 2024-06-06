namespace Decorator.HeadFirst
{
    public class Whip : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public Whip(Beverage beverage)
        {
            _beverage = beverage;
            Description = $"{_beverage.Description}, Whip";
        }

        public override string Description { get; set; }
        public override Size Size { get; set; }

        public override double Cost()
        {
            return _beverage.Cost() + 0.10;
        }
    }
}

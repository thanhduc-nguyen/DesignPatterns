namespace Decorator.HeadFirst
{
    public class Mocha : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public Mocha(Beverage beverage)
        {
            _beverage = beverage;
            Description = $"{_beverage.Description}, Mocha";
        }

        public override string Description { get; set; }
        public override Size Size { get; set; }

        public override double Cost()
        {
            return _beverage.Cost() + 0.20;
        }
    }
}

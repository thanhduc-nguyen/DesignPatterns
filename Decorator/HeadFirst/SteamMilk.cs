namespace Decorator.HeadFirst
{
    public class SteamMilk : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public SteamMilk(Beverage beverage)
        {
            _beverage = beverage;
            Description = $"{_beverage.Description}, SteamMilk";
        }

        public override string Description { get; set; }

        public override double Cost()
        {
            return _beverage.Cost() + 0.10;
        }
    }
}

namespace Decorator.HeadFirst
{
    public class Soy : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public Soy(Beverage beverage)
        {
            _beverage = beverage;
            Description = _beverage.Description;
            Size = _beverage.Size;
        }

        public override string Description { get; set; }
        public override Size Size { get; set; }

        public override double Cost()
        {
            double soy;
            switch (Size)
            {
                case Size.Tall:
                    soy = 0.10;
                    break;
                case Size.Venti:
                    soy = 0.20;
                    break;
                default:
                    soy = 0.15;
                    break;

            }
            return _beverage.Cost() + soy;
        }
    }
}

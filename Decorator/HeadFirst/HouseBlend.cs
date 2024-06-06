namespace Decorator.HeadFirst
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            Size = Size.Venti;
            Description = $"House Blend Coffee with Size: {Size}";
        }

        public override double Cost() => 0.89;
    }
}

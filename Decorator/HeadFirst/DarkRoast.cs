namespace Decorator.HeadFirst
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            Description = $"Dark Roast";
        }


        public override double Cost() => 0.99;
    }
}

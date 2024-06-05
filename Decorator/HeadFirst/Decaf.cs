namespace Decorator.HeadFirst
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            Description = "Decaf";
        }

        public override double Cost() => 1.05;
    }
}

namespace Strategy.RefactoringGuru
{
    /// <summary>
    /// Strategy.
    /// </summary>
    public interface IRouteStrategy
    {
        void BuildRoute(string pointA, string pointB);
    }

    /// <summary>
    /// Concreate strategy.
    /// </summary>
    public class CarStrategy : IRouteStrategy
    {
        public void BuildRoute(string pointA, string pointB)
        {
            Console.WriteLine($"Going from {pointA} to {pointB} by car");
        }
    }

    /// <summary>
    /// Concreate strategy.
    /// </summary>
    public class PublicTransportStrategy : IRouteStrategy
    {
        public void BuildRoute(string pointA, string pointB)
        {
            Console.WriteLine($"Going from {pointA} to {pointB} by public transport");
        }
    }

    /// <summary>
    /// Concreate strategy.
    /// </summary>
    public class WalkingStrategy : IRouteStrategy
    {
        public void BuildRoute(string pointA, string pointB)
        {
            Console.WriteLine($"Going from {pointA} to {pointB} by walking");
        }
    }

    /// <summary>
    /// Context.
    /// </summary>
    public class Navigator
    {
        private IRouteStrategy _strategy;

        public void SetStrategy(IRouteStrategy routeStrategy)
        {
            _strategy = routeStrategy;
        }

        public void BuildRoute(string pointA, string pointB)
        {
            _strategy.BuildRoute(pointA, pointB);
        }
    }
}

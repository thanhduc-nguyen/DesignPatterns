namespace AbstractFactory
{
    /// <summary>
    /// Abstract Product A.
    /// </summary>
    public interface IChair
    {
        public void HasLegs();
        public void SitOn();
    }

    /// <summary>
    /// Concrete Product A1.
    /// </summary>
    public class VictorianChair : IChair
    {
        public void HasLegs()
        {
            Console.WriteLine("VictorianChair has 4 legs");
        }

        public void SitOn()
        {
            Console.WriteLine("Sitting on VictorianChair");
        }
    }

    /// <summary>
    /// Concrete Product A2.
    /// </summary>
    public class ModernChair : IChair
    {
        public void HasLegs()
        {
            Console.WriteLine("ModernChair has no legs");
        }

        public void SitOn()
        {
            Console.WriteLine("Sitting on ModernChair");
        }
    }

    /// <summary>
    /// Abstract Product B.
    /// </summary>
    public interface ICoffeTable
    {
        public void HasLegs();
        public void SitOn();
    }

    /// <summary>
    /// Concrete Product B1.
    /// </summary>
    public class VictorianCoffeTable : ICoffeTable
    {
        public void HasLegs()
        {
            Console.WriteLine("VictorianCoffeTable has 4 legs");
        }

        public void SitOn()
        {
            Console.WriteLine("VictorianCoffeTable is not for sitting.");
        }
    }

    /// <summary>
    /// Concrete Product B2.
    /// </summary>
    public class ModernCoffeeTable : ICoffeTable
    {
        public void HasLegs()
        {
            Console.WriteLine("ModernCoffeeTable has 4 legs");
        }

        public void SitOn()
        {
            Console.WriteLine("ModernCoffeeTable is not for sitting.");
        }
    }

    /// <summary>
    /// Abstract Factory.
    /// </summary>
    public interface IFurnitureFactory
    {
        public IChair CreateChair();
        public ICoffeTable CreateCoffeeTable();
    }

    /// <summary>
    /// Concreate Factory 1.
    /// </summary>
    public class ModernFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new ModernChair();
        }

        public ICoffeTable CreateCoffeeTable()
        {
            return new ModernCoffeeTable();
        }
    }

    /// <summary>
    /// Concreate Factory 2.
    /// </summary>
    public class VictorianFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new VictorianChair();
        }

        public ICoffeTable CreateCoffeeTable()
        {
            return new VictorianCoffeTable();
        }
    }
}

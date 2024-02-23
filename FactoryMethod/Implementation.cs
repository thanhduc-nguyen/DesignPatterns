namespace FactoryMethod
{
    /// <summary>
    /// Product.
    /// </summary>
    public interface ITransport
    {
        public void Deliver();
    }

    /// <summary>
    /// Concrete Product.
    /// </summary>
    public class Truck : ITransport
    {
        public int Id { get; set; } = Random.Shared.Next(100);

        public void Deliver()
        {
            Console.WriteLine("Deliver by land in a box.");
        }
    }

    /// <summary>
    /// Concrete Product.
    /// </summary>
    public class Ship : ITransport
    {
        public int Id { get; set; } = Random.Shared.Next(100);

        public void Deliver()
        {
            Console.WriteLine("Deliver by sea in a container.");
        }
    }

    /// <summary>
    /// Creator.
    /// </summary>
    public abstract class Logistics
    {
        /// <summary>
        /// Factory Method.
        /// </summary>
        public abstract ITransport CreateProduct();

        /// <summary>
        /// Another operation of Logistics.
        /// </summary>
        public void SomeOperation()
        {
        }
    }

    /// <summary>
    /// Concrete Creator A.
    /// </summary>
    public class RoadLogistics : Logistics
    {
        public override Truck CreateProduct()
        {
            return new Truck();
        }
    }

    /// <summary>
    /// Concrete Creator B.
    /// </summary>
    public class SeaLogistics : Logistics
    {
        public override Ship CreateProduct()
        {
            return new Ship();
        }
    }
}

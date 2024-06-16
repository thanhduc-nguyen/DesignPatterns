namespace AbstractFactory
{
    /// <summary>
    /// Abstract Product A.
    /// </summary>
    public interface ITransport
    {
        public void Deliver();
    }

    /// <summary>
    /// Concrete Product A1.
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
    /// Concrete Product A2.
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
    /// Abstract Product B.
    /// </summary>
    public interface IPayment
    {
        public void Pay();
    }

    /// <summary>
    /// Concrete Product B1.
    /// </summary>
    public class Cash : IPayment
    {
        public int Id { get; set; } = Random.Shared.Next(100);

        public void Pay()
        {
            Console.WriteLine("Pay by Cash.");
        }
    }

    /// <summary>
    /// Concrete Product B2.
    /// </summary>
    public class CreditCard : IPayment
    {
        public int Id { get; set; } = Random.Shared.Next(100);

        public void Pay()
        {
            Console.WriteLine("Pay by credit card.");
        }
    }

    /// <summary>
    /// Abstract Factory.
    /// </summary>
    public abstract class Logistics
    {
        /// <summary>
        /// Factory Method 1.
        /// </summary>
        public abstract ITransport CreateTransport();

        /// <summary>
        /// Factory Method 2.
        /// </summary>
        public abstract IPayment CreatePayment();

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
        public override Truck CreateTransport()
        {
            return new Truck();
        }

        public override IPayment CreatePayment()
        {
            return new Cash();
        }
    }

    /// <summary>
    /// Concrete Creator B.
    /// </summary>
    public class SeaLogistics : Logistics
    {
        public override Ship CreateTransport()
        {
            return new Ship();
        }

        public override IPayment CreatePayment()
        {
            return new CreditCard();
        }
    }

    /// <summary>
    /// Client of the Abstract Factory.
    /// </summary>
    internal class Client(Logistics logistics)
    {
        public ITransport Transport { get; set; }
        public IPayment Payment { get; set; }

        public void getLogistics()
        {
            Transport = logistics.CreateTransport();
            Payment = logistics.CreatePayment();
        }
    }
}

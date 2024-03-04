using System.Security.Cryptography.X509Certificates;

namespace Mediator
{
    /// <summary>
    /// Mediator.
    /// </summary>
    public interface IControlTower
    {
        void Nofity(AirCraft airCraft, string eventType);
    }

    /// <summary>
    /// Component.
    /// </summary>
    public abstract class AirCraft
    {
        public string Name { get; set; }
        public int TakeOffLane { get; set; } = 0;
        protected IControlTower? _controlTower;

        public AirCraft(string name)
        {
            Name = name;
        }

        public void SetControlTower(IControlTower controlTower)
        {
            _controlTower = controlTower;
        }

        public void RequestLaneToTakeOff()
        {
            _controlTower.Nofity(this, "takeoff");
        }
    }

    /// <summary>
    /// Concrete Component A.
    /// </summary>
    public class AirPlane : AirCraft
    {
        public AirPlane(string name) : base(name)
        {
        }
    }

    /// <summary>
    /// Concrete Component B.
    /// </summary>
    public class Helicopter : AirCraft
    {
        public Helicopter(string name) : base(name)
        {
        }
    }

    /// <summary>
    /// Concrete Component C.
    /// </summary>
    public class MilitaryAirCraft : AirCraft
    {
        public MilitaryAirCraft(string name) : base(name)
        {
        }

        public void RequestLaneToEmergencyTakeOff()
        {
            _controlTower.Nofity(this, "emergency_takeoff");
        }
    }

    /// <summary>
    /// Concrete Mediator.
    /// </summary>
    public class ControlTower : IControlTower
    {
        private readonly List<AirCraft> airCrafts = new List<AirCraft>();
        //private AirPlane airPlane;
        //private Helicopter helicopter;
        //private MilitaryAirCraft militaryAirCraft;

        public void Register(AirCraft craft)
        {
            craft.SetControlTower(this);
            if (!airCrafts.Exists(x => x.Name == craft.Name))
            {
                airCrafts.Add(craft);
            }
        }

        public void Nofity(AirCraft airCraft, string eventType)
        {
            var tempList = airCrafts.Where(x => x.Name != "Air Plane 1").ToList();

            if (airCraft.Name == "Air Plane 1" && eventType == "takeoff")
            {
                Console.WriteLine("Air Plane 1 wants to take off.");
                airCraft.TakeOffLane = 1;
                foreach (var item in tempList)
                {
                    item.TakeOffLane = new Random().Next(2, 10);
                }

            }

            if (airCraft.Name == "Military AirCraft 2" && eventType == "emergency_takeoff")
            {
                Console.WriteLine("Military AirCraft 2 wants to take off on emergency.");
                airCraft.TakeOffLane = 1;
                foreach (var item in tempList)
                {
                    item.TakeOffLane = 0;
                }
            }

        }

        public void Display()
        {
            Console.WriteLine("========== BOARD ==========");
            foreach (var item in airCrafts)
            {
                Console.WriteLine($"{item.Name} will take off at lane {item.TakeOffLane}.");
            }
        }
    }
}

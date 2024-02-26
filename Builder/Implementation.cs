namespace BuilderPattern
{
    public abstract class Architecture
    {
        public int Rooms { get; set; }
        public bool HasGarage { get; set; }
        public bool HasFancyStatues { get; set; }
        public bool HasGarden { get; set; }
        public bool HasSwimmingPool { get; set; }
        public virtual void ShowOff()
        {
            Console.WriteLine($"===================");
            Console.WriteLine($"The {GetType().Name} specs");
            Console.WriteLine($"Rooms: {Rooms}");
            Console.WriteLine($"Garage: {(HasGarage ? "Yes" : "No")}");
            Console.WriteLine($"Fancy Statues: {(HasFancyStatues ? "Yes" : "No")}");
            Console.WriteLine($"Garden: {(HasGarden ? "Yes" : "No")}");
            Console.WriteLine($"Swimming Pool: {(HasSwimmingPool ? "Yes" : "No")}");
            Console.WriteLine($"===================\n");
        }
    }

    /// <summary>
    /// Product 1.
    /// </summary>
    public class House : Architecture
    {
    }

    /// <summary>
    /// Product 2.
    /// </summary>
    public class Castle : Architecture
    {
    }

    /// <summary>
    /// Abstract Builder.
    /// </summary>
    public interface IBuilder
    {
        public void Reset();
        public void BuildRooms(int number);
        public void BuildGarage();
        public void BuildFancyStatues();
        public void BuildGarden();
        public void BuildSwimmingPool();
        public Architecture GetArchitecture();
    }

    /// <summary>
    /// Concreate Builder 1.
    /// </summary>
    public class HouseBuilder : IBuilder
    {
        private House _house = new House();

        public HouseBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            _house = new House();
        }

        public void BuildRooms(int number)
        {
            _house.Rooms = number;
        }

        public void BuildGarage()
        {
            _house.HasGarage = true;
        }

        public void BuildFancyStatues()
        {
            _house.HasFancyStatues = true;
        }

        public void BuildGarden()
        {
            _house.HasGarden = true;
        }

        public void BuildSwimmingPool()
        {
            _house.HasSwimmingPool = true;
        }

        public Architecture GetArchitecture()
        {
            var result = _house;
            Reset();
            return result;
        }
    }

    /// <summary>
    /// Concreate Builder 2.
    /// </summary>
    public class CastleBuilder : IBuilder
    {
        private Castle _castle = new Castle();

        public CastleBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            _castle = new Castle();
        }

        public void BuildRooms(int number)
        {
            _castle.Rooms = number;
        }

        public void BuildGarage()
        {
            _castle.HasGarage = true;
        }

        public void BuildFancyStatues()
        {
            _castle.HasFancyStatues = true;
        }

        public void BuildGarden()
        {
            _castle.HasGarden = true;
        }

        public void BuildSwimmingPool()
        {
            _castle.HasSwimmingPool = true;
        }

        public Architecture GetArchitecture()
        {
            var result = _castle;
            Reset();
            return result;
        }
    }

    /// <summary>
    /// Director.
    /// </summary>
    public class Director
    {
        private IBuilder _builder;

        public IBuilder Builder
        {
            set { _builder = value; }
        }

        public void BuildAHouseWithGarage()
        {
            _builder.BuildRooms(5);
            _builder.BuildGarage();
        }

        public void BuildAHouseWithFullAmenities()
        {
            _builder.BuildRooms(6);
            _builder.BuildGarage();
            _builder.BuildGarden();
            _builder.BuildFancyStatues();
            _builder.BuildSwimmingPool();
        }
    }
}

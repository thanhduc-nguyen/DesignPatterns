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
    /// Product A1.
    /// </summary>
    public class House : Architecture
    {
    }

    /// <summary>
    /// Product A2.
    /// </summary>
    public class Castle : Architecture
    {
    }

    /// <summary>
    /// Product B.
    /// </summary>
    public class BluePrint
    {
        public int NumberOfRooms { get; set; }
        public bool Garage { get; set; }
        public bool Statues { get; set; }
        public bool Garden { get; set; }
        public bool SwimmingPool { get; set; }
        public void GetInformation()
        {
            Console.WriteLine("=======================================");
            Console.WriteLine($"Information in this blueprint: This architecture consists of {NumberOfRooms} rooms, {(Garage ? "with a garage," : "")} " +
                $"{(Statues ? "some fancy statues," : "")} {(Garden ? "a garden," : "")} {(SwimmingPool ? "and a swimming pool." : "")}");
            Console.WriteLine("=======================================\n");
        }
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
    }

    /// <summary>
    /// Concreate Builder A1.
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
    /// Concreate Builder A2.
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
    /// Concreate Builder B.
    /// </summary>
    public class BluePrintBuilder : IBuilder
    {
        private BluePrint _bluePrint = new BluePrint();

        public BluePrintBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            _bluePrint = new BluePrint();
        }

        public void BuildRooms(int number)
        {
            _bluePrint.NumberOfRooms = number;
        }

        public void BuildGarage()
        {
            _bluePrint.Garage = true;
        }

        public void BuildFancyStatues()
        {
            _bluePrint.Statues = true;
        }

        public void BuildGarden()
        {
            _bluePrint.Garden = true;
        }

        public void BuildSwimmingPool()
        {
            _bluePrint.SwimmingPool = true;
        }

        public BluePrint GetBluePrint()
        {
            var result = _bluePrint;
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

        public void BuildABluePrint()
        {
            _builder.BuildRooms(3);
            _builder.BuildGarage();
            _builder.BuildGarden();
            _builder.BuildFancyStatues();
            _builder.BuildSwimmingPool();
        }
    }
}

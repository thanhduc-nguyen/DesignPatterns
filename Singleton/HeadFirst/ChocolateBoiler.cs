namespace Singleton.HeadFirst
{
    public class ChocolateBoiler
    {
        private static readonly Lazy<ChocolateBoiler> _instance = new Lazy<ChocolateBoiler>(() => new ChocolateBoiler());

        public bool Empty { get; set; }
        public bool Boiled { get; set; }

        private ChocolateBoiler()
        {
            Empty = true;
            Boiled = false;
        }

        public static ChocolateBoiler Instance
        {
            get { return _instance.Value; }
        }


        public void Fill()
        {
            if (Empty)
            {
                Empty = false;
                Boiled = false;
                // fill the boiler with a milk/chocolate mixture
            }
        }
        public void Drain()
        {
            if (!Empty && Boiled)
            {
                // drain the boiled milk and chocolate
                Empty = true;
            }
        }
        public void Boil()
        {
            if (!Empty && !Boiled)
            {
                // bring the contents to a boil
                Boiled = true;
            }
        }
    }
}

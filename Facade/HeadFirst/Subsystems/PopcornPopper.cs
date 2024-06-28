namespace Facade.HeadFirst.Subsystems
{
    public class PopcornPopper(string description)
    {
        public void On()
        {
            Console.WriteLine($"{description} on");
        }

        public void Off()
        {
            Console.WriteLine($"{description} off");
        }

        public void Pop()
        {
            Console.WriteLine($"{description} popping popcorn!");
        }

        public override string ToString()
        {
            return description;
        }
    }
}

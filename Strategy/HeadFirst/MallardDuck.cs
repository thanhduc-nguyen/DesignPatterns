namespace Strategy.HeadFirst
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            _quackBehavior = new Quack();
            _flyBehavior = new FlyWithWings();
        }

        public override void Display()
        {
            throw new NotImplementedException();
        }
    }
}

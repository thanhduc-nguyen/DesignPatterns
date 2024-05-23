namespace Strategy.HeadFirst
{
    public class ModelDuck : Duck
    {
        public ModelDuck(IQuackBehavior quackBehavior, IFlyBehavior flyBehavior)
        {
            _quackBehavior = quackBehavior;
            _flyBehavior = flyBehavior;
        }

        public override void Display()
        {
            throw new NotImplementedException();
        }
    }
}

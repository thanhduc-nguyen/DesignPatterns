namespace Adapter.HeadFirst
{
    /// <summary>
    /// Class adapter.Target: Turkey. Adaptee: Duck.
    /// </summary>
    /// <param name="duck"></param>
    public class DuckAdapter(IDuck duck) : MallardDuck, ITurkey
    {
        public void Gobble()
        {
            duck.Quack();
        }

        public new void Fly()
        {
            if (new Random().Next(5) == 0)
            {
                duck.Fly();
            }
        }
    }
}

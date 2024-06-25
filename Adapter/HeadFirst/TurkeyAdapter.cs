namespace Adapter.HeadFirst
{
    /// <summary>
    /// Object adapter. Target: Duck. Adaptee: Turkey.
    /// </summary>
    /// <param name="turkey"></param>
    public class TurkeyAdapter(ITurkey turkey) : IDuck
    {
        public void Quack()
        {
            turkey.Gobble();
        }

        public void Fly()
        {
            for (int i = 0; i < 5; i++)
            {
                turkey.Fly();
            }
        }
    }
}

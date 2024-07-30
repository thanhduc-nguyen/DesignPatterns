namespace Memento.RefactoringGuru
{
    public class CareTaker : IObserver
    {
        private static readonly Lazy<CareTaker> _instance = new Lazy<CareTaker>(() => new CareTaker());
        private Hero _hero;
        private Stack<Snapshot> _snapshots = new Stack<Snapshot>();

        private CareTaker()
        {
        }

        public static CareTaker Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        public void TakeCareHero(Hero hero)
        {
            _hero = hero;
        }

        public void CreateBackup()
        {
            var snapshot = _hero.Save();
            _snapshots.Push(snapshot);
            Console.WriteLine("A snapshot added.");
        }

        public void Undo()
        {
            _snapshots.Pop();
            var snapshot = _snapshots.Pop();
            _hero.Restore(snapshot);
        }

        public void Update()
        {
            CreateBackup();
        }
    }
}

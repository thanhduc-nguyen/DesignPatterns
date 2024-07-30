namespace Memento.RefactoringGuru
{
    /// <summary>
    /// Originator.
    /// </summary>
    public class Hero(string name, int level, int damage) : IObservable
    {
        private List<IObserver> _observers = new List<IObserver>();
        private string _name = name;
        private int _level = level;
        private int _damage = damage;

        public Snapshot Save()
        {
            return new Snapshot(_name, _level, _damage);
        }

        public void Restore(Snapshot memento)
        {
            _name = memento.MementoName;
            _level = memento.MementoLevel;
            _damage = memento.MementoDamage;
        }

        public void LevelUp()
        {
            _level += 1;
            _damage += 10;
            NotifyObservers();
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Hero {_name} who is in level {_level} has {_damage} damage.");
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void UnregisterObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }
    }
}
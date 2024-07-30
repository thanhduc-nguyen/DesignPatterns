namespace Memento.RefactoringGuru.NestedClasses
{
    /// <summary>
    /// Originator.
    /// </summary>
    public class Hero(string name, int level, int damage)
    {
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
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Hero {_name} who is in level {_level} has {_damage} damage.");
        }
    }
}
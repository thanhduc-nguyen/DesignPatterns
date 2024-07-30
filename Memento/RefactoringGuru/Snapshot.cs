namespace Memento.RefactoringGuru
{
    /// <summary>
    /// Memento.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="level"></param>
    /// <param name="damage"></param>
    public class Snapshot(string name, int level, int damage)
    {
        public string MementoName { get; set; } = name;
        public int MementoLevel { get; set; } = level;
        public int MementoDamage { get; set; } = damage;
    }
}

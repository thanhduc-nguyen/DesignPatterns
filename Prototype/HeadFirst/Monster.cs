namespace Prototype.HeadFirst
{
    public abstract class Monster
    {
        public int MonsterId { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public Ability Ability { get; set; }

        public abstract Monster Clone();
    }
}

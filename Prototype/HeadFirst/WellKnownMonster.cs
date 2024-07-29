namespace Prototype.HeadFirst
{
    public class WellKnownMonster : Monster
    {
        public WellKnownMonster()
        {
        }

        public WellKnownMonster(Monster monster)
        {
            MonsterId = monster.MonsterId;
            Name = monster.Name;
            Level = monster.Level;
            Ability = new Ability
            {
                Damage = monster.Ability.Damage,
                Armor = monster.Ability.Armor
            };
        }

        public override Monster Clone()
        {
            return new WellKnownMonster(this);
        }
    }
}

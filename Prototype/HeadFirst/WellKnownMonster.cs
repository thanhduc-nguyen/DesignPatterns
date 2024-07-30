using System.Text.Json;

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

        public override Monster Clone(bool deepClone)
        {
            if (deepClone)
            {
                var objectAsJson = JsonSerializer.Serialize(this);
                return JsonSerializer.Deserialize<WellKnownMonster>(objectAsJson) ?? new WellKnownMonster();
            }

            return (WellKnownMonster)MemberwiseClone();
        }
    }
}

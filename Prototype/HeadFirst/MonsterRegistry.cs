namespace Prototype.HeadFirst
{
    public class MonsterRegistry
    {
        private static readonly Lazy<MonsterRegistry> _monsterRegistry = new Lazy<MonsterRegistry>(() => new MonsterRegistry());
        private List<Monster> _monsters = new List<Monster>();

        private MonsterRegistry()
        {
            AddMonster(new WellKnownMonster
            {
                MonsterId = 1,
                Name = "M1",
                Level = 1,
                Ability = new Ability
                {
                    Damage = 100,
                    Armor = 100
                }
            });
            AddMonster(new WellKnownMonster
            {
                MonsterId = 2,
                Name = "M2",
                Level = 2,
                Ability = new Ability
                {
                    Damage = 200,
                    Armor = 200
                }
            });
            AddMonster(new DynamicPlayerGeneratedMonster
            {
                MonsterId = 3,
                Name = "M3",
                Level = 3,
                Ability = new Ability
                {
                    Damage = 300,
                    Armor = 300
                }
            });
            AddMonster(new DynamicPlayerGeneratedMonster
            {
                MonsterId = 4,
                Name = "M4",
                Level = 4,
                Ability = new Ability
                {
                    Damage = 400,
                    Armor = 400
                }
            });
            AddMonster(new DynamicPlayerGeneratedMonster
            {
                MonsterId = 5,
                Name = "M5",
                Level = 5,
                Ability = new Ability
                {
                    Damage = 500,
                    Armor = 500
                }
            });
        }

        public static MonsterRegistry Instance
        {
            get
            {
                return _monsterRegistry.Value;
            }
        }


        public void AddMonster(Monster monster)
        {
            _monsters.Add(monster);
        }

        public IEnumerable<Monster> CloneMonstersByType(string type)
        {
            foreach (var monster in _monsters)
            {
                if (type.Equals(nameof(WellKnownMonster)) && monster is WellKnownMonster)
                {
                    yield return monster.Clone();
                }
                else if (type.Equals(nameof(DynamicPlayerGeneratedMonster)) && (monster is DynamicPlayerGeneratedMonster))
                {
                    yield return monster.Clone();
                }
            }
        }

        public IEnumerator<Monster> GetAllMonsters()
        {
            var list = _monsters.GetEnumerator();
            while (list.MoveNext())
            {
                var monster = list.Current;
                yield return monster;
            }
        }
    }
}

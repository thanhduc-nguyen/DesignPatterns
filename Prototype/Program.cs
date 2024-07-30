using Prototype.HeadFirst;
using Prototype.RefactoringGuru;

Console.Title = "Prototype";

Console.WriteLine("Head First Design Pattern");
Console.WriteLine("=========================\n");

var monsterRegistry = MonsterRegistry.Instance;
var monsters = monsterRegistry.GetAllMonsters();
var monstersAfterCloned = new List<Monster>();

while (monsters.MoveNext())
{
    var monster = monsters.Current;
    Console.WriteLine($"Monster: Type: {monster.GetType().Name} - Id: {monster.MonsterId} - Name: {monster.Name} - Level: {monster.Level} - Damage: {monster.Ability.Damage} - Armor: {monster.Ability.Armor}");
}

var shallowClonedMonsters = monsterRegistry.CloneMonstersByType(nameof(WellKnownMonster), false);
foreach (var monster in shallowClonedMonsters)
{
    monstersAfterCloned.Add(monster);
    Console.WriteLine($"SHALLOW CLONED Monster: Type: {monster.GetType().Name} - Id: {monster.MonsterId} - Name: {monster.Name} - Level: {monster.Level} - Damage: {monster.Ability.Damage} - Armor: {monster.Ability.Armor}");
}

var deepClonedMonsters = monsterRegistry.CloneMonstersByType(nameof(DynamicPlayerGeneratedMonster), true);
foreach (var monster in deepClonedMonsters)
{
    monstersAfterCloned.Add(monster);
    Console.WriteLine($"DEEP CLONED Monster: Type: {monster.GetType().Name} - Id: {monster.MonsterId} - Name: {monster.Name} - Level: {monster.Level} - Damage: {monster.Ability.Damage} - Armor: {monster.Ability.Armor}");
}

Console.WriteLine("\n=== Update all abilities of ORIGINAL monsters to 0 to see the difference between shallow clone and deep clone ===");

monsters = monsterRegistry.GetAllMonsters();
while (monsters.MoveNext())
{
    var monster = monsters.Current;
    monster.Ability.Damage = 0;
    monster.Ability.Armor = 0;
    Console.WriteLine($"Updating damage and armor of {monster.Name} to 0...");

}
Console.WriteLine("=== End of update ===");

Console.WriteLine("\n=== Monsters after cloned ===");
foreach (var monster in monstersAfterCloned)
{
    Console.WriteLine($"Monster: Type: {monster.GetType().Name} - Id: {monster.MonsterId} - Name: {monster.Name} - Level: {monster.Level} - Damage: {monster.Ability.Damage} - Armor: {monster.Ability.Armor}");
}

Console.WriteLine();
Console.WriteLine("Refactoring Guru");
Console.WriteLine("================\n");
var store = PrototypeRegistry.Instance;
var robot = new Robot(1, new Infomation { Name = "R1", Brand = "Capsule" });
for (int i = 0; i < 10; i++)
{
    store.AddItem(robot.Clone());
}

for (int i = 0; i < 10; i++)
{
    var item = store.GetItem(i);
    ((Robot)item).ShowInfo();
}

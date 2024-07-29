using Prototype.HeadFirst;
using Prototype.RefactoringGuru;

Console.Title = "Prototype";

Console.WriteLine("Head First Design Pattern");
Console.WriteLine("=========================\n");

var monsterRegistry = MonsterRegistry.Instance;
var monsters = monsterRegistry.GetAllMonsters();
while (monsters.MoveNext())
{
    var monster = monsters.Current;
    Console.WriteLine($"Monster: Type: {monster.GetType().Name} - Id: {monster.MonsterId} - Name: {monster.Name} - Level: {monster.Level} - Damage: {monster.Ability.Damage} - Armor: {monster.Ability.Armor}");
}

var clonedMonsters = monsterRegistry.CloneMonstersByType(nameof(DynamicPlayerGeneratedMonster));
foreach (var monster in clonedMonsters)
{
    Console.WriteLine($"CLONED Monster: Type: {monster.GetType().Name} - Id: {monster.MonsterId} - Name: {monster.Name} - Level: {monster.Level} - Damage: {monster.Ability.Damage} - Armor: {monster.Ability.Armor}");
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

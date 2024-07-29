using Prototype.RefactoringGuru;

Console.Title = "Prototype";

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


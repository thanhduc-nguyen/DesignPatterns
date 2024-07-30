using Memento.RefactoringGuru;

Console.Title = "Memento";

var store = CareTaker.Instance;
var hero = new Hero("Trunks", 1, 10);
hero.RegisterObserver(store);
store.TakeCareHero(hero);

hero.ShowInfo();

for (int i = 0; i < 9; i++)
{
    hero.LevelUp();
}

hero.ShowInfo();

store.Undo();
hero.ShowInfo();
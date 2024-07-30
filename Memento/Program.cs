using Memento.RefactoringGuru.NestedClasses;

Console.Title = "Memento";

var store = CareTaker.Instance;
var hero = new Hero("Trunks", 1, 10);
store.TakeCareHero(hero);

hero.ShowInfo();

store.CreateBackup();
hero.LevelUp();
hero.ShowInfo();

store.Undo();
hero.ShowInfo();
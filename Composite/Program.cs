﻿using Composite.HeadFirst;
using Composite.RefactoringGuru;

Console.Title = "Composite";

Console.WriteLine("Head First Design Pattern");
Console.WriteLine("=========================\n");

MenuComponent pancakeHouseMenu = new Menu("PANCAKE HOUSE MENU", "Breakfast");
MenuComponent dinerMenu = new Menu("DINER MENU", "Lunch");
MenuComponent cafeMenu = new Menu("CAFE MENU", "Dinner");
MenuComponent dessertMenu = new Menu("DESSERT MENU", "Dessert of course!");
MenuComponent allMenus = new Menu("ALL MENUS", "All menus combined");
allMenus.Add(pancakeHouseMenu);
allMenus.Add(dinerMenu);
allMenus.Add(cafeMenu);

pancakeHouseMenu.Add(new MenuItem("K&B's Pancake Breakfast", "Pancakes with scrambled eggs, and toast", true, 2.99m));
pancakeHouseMenu.Add(new MenuItem("Regular Pancake Breakfast", "Pancakes with fried eggs, sausage", false, 2.99m));
pancakeHouseMenu.Add(new MenuItem("Blueberry Pancakes", "Pancakes made with fresh blueberries, and blueberry syrup", true, 3.49m));
pancakeHouseMenu.Add(new MenuItem("Waffles", "Waffles, with your choice of blueberries or strawberries", true, 3.59m));

dinerMenu.Add(new MenuItem("Vegetarian BLT", "(Fakin') Bacon with lettuce & tomato on whole wheat", true, 2.99m));
dinerMenu.Add(new MenuItem("BLT", "Bacon with lettuce & tomato on whole wheat", false, 2.99m));
dinerMenu.Add(new MenuItem("Soup of the day", "A bowl of the soup of the day, with a side of potato salad", false, 3.29m));
dinerMenu.Add(new MenuItem("Hotdog", "A hot dog, with sauerkraut, relish, onions, topped with cheese", false, 3.05m));
dinerMenu.Add(new MenuItem("Steamed Veggies and Brown Rice", "Steamed vegetables over brown rice", true, 3.99m));
dinerMenu.Add(new MenuItem("Pasta", "Spaghetti with Marinara Sauce, and a slice of sourdough bread", true, 3.89m));
dinerMenu.Add(new MenuItem("Pasta", "Spaghetti with Marinara Sauce, and a slice of sourdough bread", true, 3.89m));

dinerMenu.Add(dessertMenu);

dessertMenu.Add(new MenuItem("Apple Pie", "Apple pie with a flakey crust, topped with vanilla ice cream", true, 1.59m));

dessertMenu.Add(new MenuItem("Apple Pie", "Apple pie with a flakey crust, topped with vanilla icecream", true, 1.59m));
dessertMenu.Add(new MenuItem("Cheesecake", "Creamy New York cheesecake, with a chocolate graham crust", true, 1.99m));
dessertMenu.Add(new MenuItem("Sorbet", "A scoop of raspberry and a scoop of lime", true, 1.89m));

cafeMenu.Add(new MenuItem("Veggie Burger and Air Fries", "Veggie burger on a whole wheat bun, lettuce, tomato, and fries", true, 3.99m));
cafeMenu.Add(new MenuItem("Soup of the day", "A cup of the soup of the day, with a side salad", false, 3.69m));
cafeMenu.Add(new MenuItem("Burrito", "A large burrito, with whole pinto beans, salsa, guacamole", true, 4.29m));

Waitress waitress = new Waitress(allMenus);
waitress.PrintMenu();
waitress.PrintVegetarianMenu();

Console.WriteLine();
Console.WriteLine("Refactoring Guru");
Console.WriteLine("================\n");

Box package = new Box("Package");
Box box1 = new Box("Box 1");
Box box2 = new Box("Box 2")
{
    Price = 5m,
};
Product paper = new Product("Paper")
{
    Price = 10m,
};

package.AddItem(box1);
package.AddItem(box2);
package.AddItem(paper);

Product hammer = new Product("Hammer")
{
    Price = 10m,
};
Box box3 = new Box("Box 3");
Box box4 = new Box("Box 4");

box1.AddItem(hammer);
box2.AddItem(box3);
box2.AddItem(box4);

Product phone = new Product("Phone")
{
    Price = 200m,
};
Product headphones = new Product("Headphones")
{
    Price = 10m
};
Product charger = new Product("Charger")
{
    Price = 10m
};

box3.AddItem(phone);
box3.AddItem(headphones);
box4.AddItem(charger);

Console.WriteLine($"Box 4 total price: {box4.TotalPrice()}");
Console.WriteLine($"Package total price: {package.TotalPrice()}");
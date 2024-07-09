namespace Composite.HeadFirst
{
    public class Waitress(MenuComponent allMenus)
    {
        public void PrintMenu()
        {
            allMenus.Print();
        }

        public void PrintVegetarianMenu()
        {
            IEnumerator<MenuComponent> iterator = allMenus.CreateIterator();
            Console.WriteLine("\nVEGETARIAN MENU\n----");
            while (iterator.MoveNext())
            {
                MenuComponent menuComponent = iterator.Current;
                try
                {
                    if (menuComponent.Vegetarian)
                    {
                        menuComponent.Print();
                    }
                }
                catch (NotImplementedException e) { }
            }
        }
    }
}

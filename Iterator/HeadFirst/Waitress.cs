namespace Iterator.HeadFirst
{
    public class Waitress(PancakeHouseMenu pancakeHouseMenu, DinerMenu dinerMenu)
    {
        public void PrintMenu()
        {
            IIterator pancakeIterator = pancakeHouseMenu.CreateIterator();
            IIterator dinerIterator = dinerMenu.CreateIterator();

            Console.WriteLine("MENU\n----\nBREAKFAST");
            PrintMenu(pancakeIterator);
            Console.WriteLine("\nLUNCH");
            PrintMenu(dinerIterator);
        }

        private void PrintMenu(IIterator iterator)
        {
            while (iterator.HasNext())
            {
                MenuItem menuItem = (MenuItem)iterator.Next();
                Console.WriteLine($"{menuItem.Name} {menuItem.Price} {menuItem.Description}");
            }
        }
    }
}

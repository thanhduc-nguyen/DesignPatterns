namespace Iterator.HeadFirst
{
    public class DinerMenuIterator(MenuItem[] items) : IIterator
    {
        int position = 0;

        public bool HasNext()
        {
            if (position >= items.Length || items[position] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public object Next()
        {
            MenuItem menuItem = items[position];
            position = position + 1;
            return menuItem;
        }
    }
}

namespace Iterator.HeadFirst
{
    public class PancakeHouseIterator(List<MenuItem> items) : IIterator
    {
        int position;

        public bool HasNext()
        {
            if (position >= items.Count || items[position] == null)
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
            MenuItem item = items[position];
            position++;
            return item;
        }
    }
}

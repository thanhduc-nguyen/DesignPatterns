namespace Composite.HeadFirst
{
    public abstract class MenuComponent
    {
        public virtual MenuComponent GetChild(int i)
        {
            throw new NotImplementedException();
        }

        public virtual string Name
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public virtual string Description
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public virtual decimal Price
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public virtual bool Vegetarian
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public virtual void Add(MenuComponent menuComponent)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(MenuComponent menuComponent)
        {
            throw new NotImplementedException();
        }

        public virtual void Print()
        {
            throw new NotImplementedException();
        }

        public virtual IEnumerator<MenuComponent> CreateIterator()
        {
            throw new NotImplementedException();
        }
    }
}

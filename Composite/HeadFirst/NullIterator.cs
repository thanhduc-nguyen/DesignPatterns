using System.Collections;

namespace Composite.HeadFirst
{
    public class NullIterator : IEnumerator<MenuComponent>
    {
        public void Dispose() { }

        public bool MoveNext() => false;

        public void Reset() { }

        public MenuComponent Current => null;

        object IEnumerator.Current => Current;
    }
}
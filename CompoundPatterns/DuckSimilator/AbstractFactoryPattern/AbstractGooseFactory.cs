using CompoundPatterns.Entities;

namespace CompoundPatterns.AbstractFactoryPattern
{
    public abstract class AbstractGooseFactory
    {
        public abstract GooseAdapter CreateGoose();
    }
}

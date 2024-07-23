using CompoundPatterns.Entities;

namespace CompoundPatterns.AbstractFactoryPattern
{
    internal class AdapterGooseFactory : AbstractGooseFactory
    {
        public override GooseAdapter CreateGoose()
        {
            return new GooseAdapter(new Goose());
        }
    }
}

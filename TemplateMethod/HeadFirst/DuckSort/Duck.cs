namespace TemplateMethod.HeadFirst.DuckSort
{
    public class Duck(string name, int weight) : IComparable<Duck>
    {
        public string Name { get; } = name;
        public int Weight { get; } = weight;

        public int CompareTo(Duck other)
        {
            if (Weight < other.Weight)
            {
                return -1;
            }

            return Weight == other.Weight ? 0 : 1; //Weight > other.Weight;
        }

        public override string ToString() => $"{Name} weighs {Weight}";
    }
}

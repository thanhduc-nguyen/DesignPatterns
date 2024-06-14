using AbstractFactory.HeadFirst.Ingredients.Abstracts;

namespace AbstractFactory.HeadFirst.Creators
{
    public interface IPizzaIngredientFactory
    {
        public Dough CreateDough();
        public Sauce CreateSauce();
        public Cheese CreateCheese();
        public List<Veggies> CreateVeggies();
        public Pepperoni CreatePepperoni();
        public Clams CreateClam();
    }
}

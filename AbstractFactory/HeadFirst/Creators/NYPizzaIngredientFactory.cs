using AbstractFactory.HeadFirst.Ingredients.Abstracts;
using AbstractFactory.HeadFirst.Ingredients.Concretes;

namespace AbstractFactory.HeadFirst.Creators
{
    public class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Dough CreateDough()
        {
            return new ThinCrustDough();
        }
        public Sauce CreateSauce()
        {
            return new MarinaraSauce();
        }
        public Cheese CreateCheese()
        {
            return new ReggianoCheese();
        }
        public List<Veggies> CreateVeggies()
        {
            var veggies = new List<Veggies> { new Garlic(), new Onion(), new Mushroom(), new RedPepper() };
            return veggies;
        }
        public Pepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }
        public Clams CreateClam()
        {
            return new FreshClams();
        }
    }
}

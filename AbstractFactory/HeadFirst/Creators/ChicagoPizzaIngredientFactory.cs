using AbstractFactory.HeadFirst.Ingredients.Abstracts;
using AbstractFactory.HeadFirst.Ingredients.Concretes;

namespace AbstractFactory.HeadFirst.Creators
{
    public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Dough CreateDough()
        {
            return new ThickCrustDough();
        }
        public Sauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }
        public Cheese CreateCheese()
        {
            return new MozzarellaCheese();
        }
        public List<Veggies> CreateVeggies()
        {
            var veggies = new List<Veggies> { new Eggplant(), new Spinach(), new BlackOlives() };
            return veggies;
        }
        public Pepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }
        public Clams CreateClam()
        {
            return new FrozenClams();
        }
    }
}

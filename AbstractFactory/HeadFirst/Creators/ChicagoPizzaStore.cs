using AbstractFactory.HeadFirst.Products.Abstracts;
using AbstractFactory.HeadFirst.Products.Concretes;

namespace AbstractFactory.HeadFirst.Creators
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza;
            IPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

            switch (type)
            {
                case "cheese":
                    pizza = new CheesePizza(ingredientFactory)
                    {
                        Name = "Chicago Style Cheese Pizza"
                    };
                    return pizza;
                case "clam":
                    pizza = new ClamPizza(ingredientFactory)
                    {
                        Name = "Chicago Style Clam Pizza"
                    };
                    return pizza;
                case "pepperoni":
                    pizza = new PepperoniPizza(ingredientFactory)
                    {
                        Name = "Chicago Style Pepperoni Pizza"
                    };
                    return pizza;
                case "veggie":
                    pizza = new VeggiePizza(ingredientFactory)
                    {
                        Name = "Chicago Style Veggie Pizza"
                    };
                    return pizza;
                default:
                    return null;
            }
        }
    }
}

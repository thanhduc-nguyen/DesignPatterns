using AbstractFactory.HeadFirst.Products.Abstracts;
using AbstractFactory.HeadFirst.Products.Concretes;

namespace AbstractFactory.HeadFirst.Creators
{
    public class NYPizzaStore : PizzaStore
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
                        Name = "New York Style Cheese Pizza"
                    };
                    return pizza;
                case "clam":
                    pizza = new ClamPizza(ingredientFactory)
                    {
                        Name = "New York Style Clam Pizza"
                    };
                    return pizza;
                case "pepperoni":
                    pizza = new PepperoniPizza(ingredientFactory)
                    {
                        Name = "New York Style Pepperoni Pizza"
                    };
                    return pizza;
                case "veggie":
                    pizza = new VeggiePizza(ingredientFactory)
                    {
                        Name = "New York Style Veggie Pizza"
                    };
                    return pizza;
                default:
                    return null;
            }
        }
    }
}

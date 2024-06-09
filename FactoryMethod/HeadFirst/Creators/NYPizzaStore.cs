using FactoryMethod.HeadFirst.Products;

namespace FactoryMethod.HeadFirst.Creators
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "cheese":
                    return new NYStyleCheesePizza();
                case "clam":
                    return new NYStyleClamPizza();
                case "pepperoni":
                    return new NYStylePepperoniPizza();
                case "veggie":
                    return new NYStyleVeggiePizza();
                default:
                    return null;
            }
        }
    }
}

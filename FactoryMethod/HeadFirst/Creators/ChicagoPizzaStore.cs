using FactoryMethod.HeadFirst.Products;

namespace FactoryMethod.HeadFirst.Creators
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "cheese":
                    return new ChicagoStyleCheesePizza();
                case "clam":
                    return new ChicagoStyleClamPizza();
                case "pepperoni":
                    return new ChicagoStylePepperoniPizza();
                case "veggie":
                    return new ChicagoStyleVeggiePizza();
                default:
                    return null;
            }
        }
    }
}

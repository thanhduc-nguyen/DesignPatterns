namespace TemplateMethod.HeadFirst.StarbuzzCoffee
{
    public class CoffeeWithHook : CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }

        public override bool CustomerWantsCondiments()
        {
            string answer = GetUserInput();
            if (answer.ToLower().StartsWith("y"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private string GetUserInput()
        {
            string answer;
            Console.Write("Would you like milk and sugar with your coffee (y / n)? ");
            answer = Console.ReadLine();

            if (string.IsNullOrEmpty(answer))
            {
                answer = "n";
            }

            return answer;
        }
    }
}

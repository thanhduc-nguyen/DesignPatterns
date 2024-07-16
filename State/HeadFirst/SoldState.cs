namespace State.HeadFirst
{
    public class SoldState(GumballMachine gumballMachine) : IState
    {
        public void InsertQuarter()
        {
            Console.WriteLine("Please wait, we're already giving you a gumball");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Sorry, you already turned the crank");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Turning twice doesn't get you another gumball!");
        }

        public void Dispense()
        {
            gumballMachine.ReleaseBall();
            if (gumballMachine.Count > 0)
            {
                gumballMachine.SetState(gumballMachine.NoQuarterState);
            }
            else
            {
                Console.WriteLine("Oops, out of gumballs!");
                gumballMachine.SetState(gumballMachine.SoldOutState);
            }

            if (gumballMachine.Count == 0)
            {
                gumballMachine.Refill(10);
            }
        }

        public void Refill()
        {
        }

        public override string ToString()
        {
            return "dispensing a gumball";
        }
    }
}

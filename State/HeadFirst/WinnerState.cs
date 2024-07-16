namespace State.HeadFirst
{
    public class WinnerState(GumballMachine gumballMachine) : IState
    {
        public void InsertQuarter()
        {
            Console.WriteLine("Please wait, we're already giving you a Gumball");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Please wait, we're already giving you a Gumball");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Please wait, we're already giving you a Gumball");
        }

        public void Dispense()
        {
            gumballMachine.ReleaseBall();
            if (gumballMachine.Count == 0)
            {
                gumballMachine.SetState(gumballMachine.SoldOutState);
            }
            else
            {
                gumballMachine.ReleaseBall();
                Console.WriteLine("YOU'RE A WINNER! You got two gumballs for your quarter");
                if (gumballMachine.Count > 0)
                {
                    gumballMachine.SetState(gumballMachine.NoQuarterState);
                }
                else
                {
                    Console.WriteLine("Oops, out of gumballs!");
                    gumballMachine.SetState(gumballMachine.SoldOutState);
                }
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
            return "waiting for quarter";
        }
    }
}

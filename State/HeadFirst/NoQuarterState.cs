﻿namespace State.HeadFirst
{
    public class NoQuarterState(GumballMachine gumballMachine) : IState
    {
        public void InsertQuarter()
        {
            Console.WriteLine("You inserted a quarter");
            gumballMachine.SetState(gumballMachine.HasQuarterState);
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You haven't inserted a quarter");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned, but there's no quarter");
        }

        public void Dispense()
        {
            Console.WriteLine("You need to pay first");
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

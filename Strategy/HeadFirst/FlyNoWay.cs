﻿namespace Strategy.HeadFirst
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can’t fly");
        }
    }
}

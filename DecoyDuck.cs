using System;

namespace StrategyPattern
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            FlyBehaviour = new FlyNoWay();
            QuackBehaviour = new MuteQuack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a Decoy Duck.");
        }
    }
}
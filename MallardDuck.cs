using System;

namespace StrategyPattern
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            FlyBehaviour = new FlyWithWings();
            QuackBehaviour = new Quack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real Mallard Duck.");
        }
    }
}

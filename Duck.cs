using System;

namespace StrategyPattern
{
    public abstract class Duck
    {
        public IFlyBehaviour FlyBehaviour { get; set; }
        public IQuackBehaviour QuackBehaviour { get; set; }

        public Duck()
        {
            
        }

        public void SetFlyBehaviour(IFlyBehaviour fb)
        {
            FlyBehaviour = fb;
        }

        public void SetQuackBehaviour(IQuackBehaviour qb)
        {
            QuackBehaviour = qb;
        }

        public void PerformFly()
        {
            FlyBehaviour.Fly();
        }

        public void PerformQuack()
        {
            QuackBehaviour.Speak();
        }

        public void Swim()
        {
            Console.WriteLine("All ducks can swim, even decoys");
        }

        public abstract void Display();
    }
}

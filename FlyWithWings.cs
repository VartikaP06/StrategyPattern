using System;

namespace StrategyPattern
{
    public class FlyWithWings : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I'm Flying!!");
        }
    }
}

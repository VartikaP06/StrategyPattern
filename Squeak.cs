using System;

namespace StrategyPattern
{
    public class Squeak : IQuackBehaviour
    {
        public void Speak()
        {
            Console.WriteLine("Squeak");
        }
    }
}

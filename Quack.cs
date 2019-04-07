using System;

namespace StrategyPattern
{
    public class Quack : IQuackBehaviour
    {
        public void Speak()
        {
            Console.WriteLine("Quack");
        }
    }
}

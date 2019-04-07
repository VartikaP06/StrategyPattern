using System;

namespace StrategyPattern
{
    public class MuteQuack : IQuackBehaviour
    {
        public void Speak()
        {
            Console.WriteLine("Silence");
        }
    }
}

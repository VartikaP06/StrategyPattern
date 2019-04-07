using System;

namespace StrategyPattern
{
    public class MiniDuckSimulator
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.Display();
            mallard.PerformQuack();
            mallard.PerformFly();
            Console.WriteLine();

            Duck model = new ModelDuck();
            model.Display();
            model.PerformQuack();
            model.PerformFly();
            model.SetFlyBehaviour(new FlyRocketPowered());
            model.PerformFly();
            Console.WriteLine();

            Duck decoy = new DecoyDuck();
            decoy.Display();
            decoy.PerformQuack();
            decoy.PerformFly();
            decoy.SetQuackBehaviour(new Squeak());
            Console.WriteLine();

            Duck rubber = new RubberDuck();
            rubber.Display();
            rubber.PerformQuack();
            rubber.PerformFly();
            rubber.Swim();
            Console.WriteLine();
        }
    }
}

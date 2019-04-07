# StrategyPattern
The Strategy design pattern.


We have a Duck Simulation App.

1. There are different types of ducks in the app
2. Some can fly and quack
3. Some can fly and squeak
4. Some cannot fly, but just quack, etc

Designing an app to hold the different models of the duck and their different behaviours, requires the Strategy Pattern to be used.

The Strategy pattern defins a family of algorithms, encapsulates each one and makes them imtechangeable.

In the code, I have
1. The base class Duck, that holds the common functionality across all Ducks, and the behaviour that remains constant.
2. The behaviour that changes across ducks, has been moved to separate behaviour classes, IFlyBehaviour and IQuackBehaviour
3. These behaviour classes are implemented, to show different kinds of fly and quack behaviour, eg: FlyWithWings(), Quack(), etc
4. The SetFlyBehaviour and SetQuackBehaviour methods, can set the behaviour dynamically, at runtime.

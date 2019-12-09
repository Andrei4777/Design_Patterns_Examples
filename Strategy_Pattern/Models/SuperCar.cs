using System;
using Strategy_Pattern.Behavior.Ride;
using Strategy_Pattern.Behavior.Brake;
using Strategy_Pattern.Behavior.Park;

namespace Strategy_Pattern
{
    public class SuperCar : Car
    {       
        public SuperCar()
        {
            _rideBehavior = new FastRide();
            _brakeBehavior = new SportBrake();
            _parkBehavior = new NoPark();
        }

        public override void Display()
        {
            Console.WriteLine("<<Super car>>");
        }
    }
}

using System;

namespace Strategy_Pattern.Models
{
    public class CustomCar : Car
    {

        public CustomCar()
        {
            _rideBehavior = new Strategy_Pattern.Behavior.Ride.FastRide();
            _brakeBehavior = new Behavior.Brake.SportBrake();
            
        }

        public override void Display()
        {
            Console.WriteLine("<<Tuning car>>");
        }
    }
}

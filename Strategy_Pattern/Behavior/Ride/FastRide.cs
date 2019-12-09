using System;
using Strategy_Pattern.Interface;

namespace Strategy_Pattern.Behavior.Ride
{
    public class FastRide : IRideable
    {
        public void Ride()
        {
            Console.WriteLine("Speed: 210 km/h");
        }
    }
}

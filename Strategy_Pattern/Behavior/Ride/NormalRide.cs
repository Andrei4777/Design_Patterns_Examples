using System;
using Strategy_Pattern.Interface;

namespace Strategy_Pattern
{
    public class NormalRide : IRideable
    {
        public void Ride()
        {
            Console.WriteLine("Speed: 120 km/h");
        }
    }
}
using System;
using Strategy_Pattern.Interface;

namespace Strategy_Pattern.Behavior.Brake
{
    public class SportBrake : IBrakeable
    {
        public void Brake()
        {
            Console.WriteLine("Braking distance: 10 m"); ;
        }
    }
}

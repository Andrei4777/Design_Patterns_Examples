using System;
using Strategy_Pattern.Interface;

namespace Strategy_Pattern
{
    public class NormalBrake : IBrakeable
    {
        public void Brake()
        {
            Console.WriteLine("Brake distance: 20 m"); ;
        }
    }
}

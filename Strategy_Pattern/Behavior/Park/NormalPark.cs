using System;
using Strategy_Pattern.Interface;

namespace Strategy_Pattern.Behavior
{
    public class NormalPark : IParkable
    {
        public void Park()
        {
            Console.WriteLine("I will park myself..."); ;
        }
    }
}

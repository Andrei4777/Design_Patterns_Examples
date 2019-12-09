using System;
using Strategy_Pattern.Interface;
namespace Strategy_Pattern.Behavior.Park
{
    public class SelfPark : IParkable
    {
        public void Park()
        {
            Console.WriteLine("Auto parking..."); ;
        }
    }
}

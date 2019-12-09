using Strategy_Pattern.Interface;
using Strategy_Pattern.Behavior;

namespace Strategy_Pattern
{
    public abstract class Car
    {
        protected IBrakeable _brakeBehavior;
        protected IRideable _rideBehavior;
        protected IParkable _parkBehavior;

        public Car()
        {
            _brakeBehavior = new NormalBrake();
            _rideBehavior = new NormalRide();
            _parkBehavior = new NormalPark();
        }

        public void Ride()
        {
            _rideBehavior.Ride();
        }

        public void Brake()
        {
            _brakeBehavior.Brake();
        }

        public void Park()
        {
            _parkBehavior.Park();
        }

        public abstract void Display();        

        public void SetRideBehavior(IRideable ride)
        {
            _rideBehavior = ride;
        }

        public void SetBrakeBehavior(IBrakeable brake)
        {
            _brakeBehavior = brake;
        }

        public void SetParkBehavior(IParkable park)
        {
            _parkBehavior = park;
        }
    }
}

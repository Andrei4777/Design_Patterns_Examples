using Strategy_Pattern.Models;
using System;
using System.Collections.Generic;

namespace Strategy_Pattern
{
   public class Program
    {
        static void Main(string[] args)
        {
            FamilyCar familyCar = new FamilyCar();
            SuperCar superCar = new SuperCar();
            NormalCar normalCar = new NormalCar();

            List<Car> cars = new List<Car>
            {
               normalCar, familyCar, superCar
            };

            foreach (var car in cars)
            {
                car.Display();
                car.Ride();
                car.Brake();
                car.Park();
                Console.WriteLine();
            }

            CustomCar customCar = new CustomCar();
            customCar.Display();
            customCar.Ride();
            customCar.Brake();            
            customCar.SetParkBehavior(new Behavior.Park.SelfPark());
            customCar.Park();

            Console.ReadKey();
        }
    }
}
